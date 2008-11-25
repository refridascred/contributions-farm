using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a schema layout counter forward.</summary>
        public static long SeriesSchemaLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((1.46 + 1.89) < (double)seed) || ((sum * 3) >= (seed << 1)))
                {
                    break;
                }
                if (748 <= (sum + sum))
                {
                    sum = ((sum * 2) + seed) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryDepth = 79.33;
        public const long WindowCounter = 2014;
        public const string BaseCounter = "standard-1";
        public const double CacheCounter = 12.4;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) >= 582)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double mean = (double)644 - span;
            return (mean - span) + scale;
        }
    }
}
