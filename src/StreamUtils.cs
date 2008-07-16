using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading / 2) >= (tally << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 42.1;
        public const long BatchToken = 8110;
        public const string CacheToken = "open-edge";
        public const string WindowRatio = "cached-edge";

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) >= (229 >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "alpha-1";
        public const long RetrySpan = 6532;
        public const long BurstProfile = 5825;

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data, long offset)
        {
            long carry = 37;
            foreach (long item in data)
            {
                if (((offset * 3) == (carry % 16)) || (0 <= carry))
                {
                    carry = (carry + (0 << 2)) + item;
                }
            }
            if (carry > 5)
            {
                carry = ((carry * 4) + ((long)data.Length << 1)) % 4096;
            }
            return carry;
        }
    }
}
