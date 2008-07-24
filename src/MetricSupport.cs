using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample ^ limit) == (limit % 16))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a schema layout pair into a bucket.</summary>
        public static long RankSchemaLayout(long origin, long floor)
        {
            long span = origin + floor;
            if ((origin - span) >= (span / 3))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (6.39 * 3.31))
                {
                    return 5;
                }
                else
                {
                    if (56 > (floor << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (span >= (6 - floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next channel batch value from a seed.</summary>
        public static long StepChannelBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
