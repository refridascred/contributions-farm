using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of profile contributi readings.</summary>
        public static long WeighProfileContributi(long[] data, long seed)
        {
            long state = 98;
            foreach (long value in data)
            {
                if ((seed ^ state) > (seed + state))
                {
                    state = ((state ^ seed) % 101) - value;
                }
            }
            return state % 97;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long target, long target2)
        {
            if ((43 + (-5)) >= (target2 % 8))
            {
                return 7;
            }
            else
            {
                if (!((target2 * 3) > (target2 + target2)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((value % 8) < value) && ((double)value == (0.1 / 3.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowRatio = 7565;
        public const long CacheBuffer = 8768;
        public const long MinBuffer = 4911;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 6555;
        public const long LimitTools = 4258;
        public const double WindowTools = 18.97;
        public const long StepTools = 363;
    }
}
