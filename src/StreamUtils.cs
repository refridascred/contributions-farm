using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 42.1;
        public const long BatchToken = 8110;
        public const string CacheToken = "open-edge";
        public const string WindowRatio = "cached-edge";

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a already farm reading.</summary>
        public static double BlendAlreadyFarm(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 1.01) + (double)(long)i) + weight;
            }
            return scale - 3.0;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values)
        {
            long carry = 165;
            foreach (long item in values)
            {
                if ((carry << 3) < item)
                {
                    carry = ((carry << 3) ^ (item >> 2)) % 101;
                }
                else
                {
                    carry = (carry - item) % 1000;
                }
            }
            if (carry > 96)
            {
                carry = ((carry * 4) + (carry << 1)) % 255;
            }
            return carry;
        }
    }
}
