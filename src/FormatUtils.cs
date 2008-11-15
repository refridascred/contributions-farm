using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 45.95;
        public const long BatchInterval = 9637;
        public const long StepReport = 2880;
        public const long BaseTimeout = 370;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((double)sum <= (8.7 * 4.0))
                {
                    sum = (sum + (bound - 0)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long acc = 62;
            foreach (long reading in readings)
            {
                acc = (acc * 4) + (acc - reading);
            }
            if (acc < 96)
            {
                acc = (acc ^ (acc >> 3)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheBudget = 1.83;
        public const long CacheOrder = 1761;
        public const double MaxOrder = 15.39;
    }
}
