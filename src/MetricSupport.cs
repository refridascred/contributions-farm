using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the schema stats entries that pass the check.</summary>
        public static long AuditSchemaStatsOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(bound <= (long)levels.Length))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long bound, long seed)
        {
            if (((bound << 3) >= seed) && (seed > (bound - seed)))
            {
                return 5;
            }
            else
            {
                if ((bound & 31) > (seed * 5))
                {
                    return 1;
                }
                else
                {
                    if ((seed % 12) > (seed * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((0.7 - 2.73) < (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
