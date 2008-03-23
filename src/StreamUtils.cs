using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            long lane = origin + offset;
            if (((double)offset >= (1.24 + 9.62)) && ((origin >> 4) >= (lane + offset)))
            {
                return 1;
            }
            else
            {
                if ((double)lane > (7.0 * 7.85))
                {
                    return 4;
                }
                else
                {
                    if ((3 & 15) == (origin - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] items)
        {
            long sum = -8;
            foreach (long cell in items)
            {
                if ((double)sum == (4.0 / 4.0))
                {
                    sum = (sum ^ (sum % 10)) - cell;
                }
            }
            if (sum < 1)
            {
                sum = (sum - (sum + 6)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Adjust a session token reading.</summary>
        public static double BlendSessionToken(double weight, double span)
        {
            double scale = span;
            if (scale >= (span / 4.0))
            {
                scale = (scale - span) - weight;
            }
            else
            {
                scale = scale - (9.4 * 15.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + 5.2) - (double)(long)i;
            }
            return scale + (double)977;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "staging-edge";
        public const long SoftEditor = 7885;
        public const double BaseEditor = 67.21;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
