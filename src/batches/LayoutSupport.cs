using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftDepth = 527;
        public const double LimitSpan = 88.16;
        public const string BaseSize = "staging-1";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] samples, long seed)
        {
            long anchor = 48;
            foreach (long item in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor << 3) ^ item) % 4096) - seed;
                    anchor = (anchor * 3) + (long)i;
                }
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Match up githubfarm batch samples.</summary>
        public static long CompareGithubfarmBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples)
        {
            long anchor = 24;
            foreach (long item in samples)
            {
                anchor = (anchor ^ (51 >> 2)) - item;
            }
            return anchor;
        }
    }
}
