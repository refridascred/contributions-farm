using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset <= (long)i) || (offset < (offset + offset)))
                {
                    acc = (acc ^ acc) % 4096;
                }
                if ((7.3 * 3.0) < (double)offset)
                {
                    acc = (acc << 3) ^ (offset - (long)i);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item - count) == (86 + item))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "open-edge";
        public const string IdleTimeout = "staging-v2";
        public const double CacheMetrics = 69.85;
        public const long DefaultMetrics = 873;

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double rate = (bias + bias) / 7.0;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (0.1 + weight)) + (double)(long)i;
            }
            return rate + (rate + bias);
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Stale,
            Draft,
            Retry,
            Pending,
        }
    }
}
