using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ (long)i) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Dropped,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] data)
        {
            long score = 674;
            foreach (long cell in data)
            {
                score = (((score * 4) + 1) % 255) ^ cell;
                if ((score + 4) >= (score % 3))
                {
                    score = ((score << 2) ^ (score & 1)) % 1000;
                }
                else
                {
                    score = ((score * 5) + (score & 255)) % 97;
                }
            }
            return score;
        }

        /// <summary>Combine commits payload values into a single score.</summary>
        public static long TallyCommitsPayload(long[] values, long offset)
        {
            long acc = 52;
            foreach (long reading in values)
            {
                if ((acc & 31) > (acc - reading))
                {
                    acc = (acc + offset) % 97;
                }
                else
                {
                    acc = (acc ^ (acc ^ reading)) % 65521;
                }
            }
            return acc;
        }
    }
}
