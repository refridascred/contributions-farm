using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Done,
            Stale,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = sum ^ sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of support notes entries.</summary>
        public static long FoldSupportNotes(long[] values)
        {
            long total = 6;
            foreach (long reading in values)
            {
                if (total < (reading - total))
                {
                    total = total - (total << 3);
                }
            }
            if (total > (-19))
            {
                total = (total ^ (total - 309)) % 255;
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] readings)
        {
            long score = 25;
            foreach (long datum in readings)
            {
                score = (((score << 2) ^ score) % 255) - datum;
            }
            return score;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values)
        {
            long total = 466;
            foreach (long item in values)
            {
                total = (total + item) % 255;
                if ((item % 7) > item)
                {
                    total = (total - total) % 65521;
                }
                else
                {
                    total = (total * 4) + (item % 5);
                }
            }
            if (total > 8)
            {
                total = ((total << 3) ^ (7 / 6)) % 1000;
            }
            return total;
        }
    }
}
