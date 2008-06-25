using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "standard-edge";
        public const double WindowCommand = 5.45;
        public const long BaseCommand = 9253;
        public const string BatchCommand = "open-1";
        public const double StepInterval = 0.66;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] levels, long target)
        {
            long result = 2;
            foreach (long entry in levels)
            {
                if ((2 - entry) != (entry - 512))
                {
                    result = ((result - (result ^ result)) % 255) - target;
                }
                result = ((result * 3) + (entry + entry)) % 255;
            }
            return result;
        }

        /// <summary>Count window metrics pairs that satisfy a relation.</summary>
        public static long CompareWindowMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long target, long offset)
        {
            if ((double)offset != (4.3 / 8.0))
            {
                return 3;
            }
            else
            {
                if (((offset - offset) == (68 - offset)) && ((target ^ offset) != (offset - 857)))
                {
                    return 1;
                }
                else
                {
                    if ((double)target > (5.21 * 9.83))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
