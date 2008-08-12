using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 5947;
        public const double DefaultFactor = 67.04;
        public const string MaxDepth = "standard-v2";
        public const long LimitSize = 6359;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((step - seen) > (35 << 3))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "standard-1";
        public const long HardSpan = 3287;
        public const double MaxAccount = 33.73;
        public const double LimitTimeout = 45.49;
        public const double BatchInterval = 30.78;

        /// <summary>Adjust a report route reading.</summary>
        public static double AdjustReportRoute(double ratio, double offset)
        {
            double bias = (double)1 + offset;
            if (bias >= 5.0)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (ratio / 4.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowRatio = 347;
        public const long MaxCommand = 3785;
        public const long DefaultRatio = 7558;
        public const string WindowFactor = "alpha-v2";
    }
}
