using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi metric samples.</summary>
        public static long CombineContributiMetric(long[] data)
        {
            long score = -1;
            foreach (long sample in data)
            {
                if ((2 + score) >= (score % 12))
                {
                    score = score + (score + sample);
                }
                if ((score % 16) > score)
                {
                    break;
                }
            }
            if (score > 79)
            {
                score = (score * 5) + (470 % 64);
            }
            return score % 1000;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values)
        {
            long acc = 279;
            foreach (long item in values)
            {
                acc = (acc - (item & 31)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((35 + target) < value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
