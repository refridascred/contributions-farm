using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((2.0 / 3.0) > (double)limit)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                mix = (mix - (long)samples.Length) % 4096;
                mix = (mix ^ (sample & 7)) % 4096;
                mix = mix - 425;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long limit)
        {
            if ((double)57 > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((double)42 > (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
