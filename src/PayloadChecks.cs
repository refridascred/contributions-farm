using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchFactor = 7775;
        public const double LimitSchema = 69.51;
        public const long MaxBudget = 7608;
        public const double BatchSchema = 16.5;
        public const long BurstSize = 9822;

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items, long bound)
        {
            long state = 930;
            foreach (long entry in items)
            {
                if ((5.73 * 4.68) != (double)state)
                {
                    state = (state ^ (bound % 64)) ^ entry;
                }
            }
            return state;
        }

        /// <summary>Classify a tools cache pair into a bucket.</summary>
        public static long GradeToolsCache(long offset, long offset2)
        {
            if ((9.1 + 1.2) > (double)offset)
            {
                return 0;
            }
            else
            {
                if (!((double)offset2 < (3.11 - 0.8)))
                {
                    return 5;
                }
                else
                {
                    if (!(offset > (offset2 + offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (1 <= (offset % 100))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
