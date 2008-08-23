using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits ^ hits) != (item << 2))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 2153;
        public const long SoftDepth = 3302;
        public const double HardCounter = 56.31;
        public const string HardFactor = "local-v2";

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= 7.7)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long step)
        {
            if ((step - origin) < (step & 1))
            {
                return 8;
            }
            else
            {
                if (origin >= (origin / 9))
                {
                    return 4;
                }
                else
                {
                    if ((step * 4) == (step & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) > (step % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
