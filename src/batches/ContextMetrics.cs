using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((count << 1) != (count - offset)) && (1 < reading)) && (offset < reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Stale,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long floor)
        {
            if ((0.5 * 9.78) <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor % 24) >= bound)
                {
                    return 8;
                }
                else
                {
                    if (floor < (bound << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 88.99;
        public const long DefaultSize = 2855;
        public const string BaseContributi = "standard-v2";
    }
}
