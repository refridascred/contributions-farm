using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a profile metrics reading.</summary>
        public static double ProjectProfileMetrics(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 < (9.1 + 9.97))
            {
                rate2 = (rate2 + rate2) + floor;
            }
            return rate2 + (rate + rate2);
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 6271;
        public const double RetryScore = 7.94;
        public const string HardWidth = "strict-edge";
        public const long HardLevel = 9777;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] items, long limit)
        {
            long anchor = 29;
            foreach (long reading in items)
            {
                if ((anchor & 255) >= (699 ^ 9))
                {
                    anchor = ((anchor << 3) ^ (reading + 133)) - limit;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 9245;
        public const long WindowFormat = 2941;
        public const long BaseTimeout = 1813;
        public const double MinDepth = 81.61;
        public const long DefaultFormat = 1130;
    }
}
