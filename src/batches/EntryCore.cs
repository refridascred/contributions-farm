using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((double)count == (15.0 / 2.0)) || ((entry << 2) > 7)) || ((entry & 255) >= (entry * 4)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cache schema entries that pass the check.</summary>
        public static long TallyCacheSchemaGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((seen + seen) > 8) || ((10 <= item) || ((double)seen == (11.0 + 7.99))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double rate, double bias)
        {
            double mean = (double)(26 - 7);
            if (mean < (bias - rate))
            {
                mean = mean - 9.0;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 5.87) + (double)(long)i;
            }
            return mean + (double)5;
        }
    }
}
