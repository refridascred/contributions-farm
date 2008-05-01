using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] values)
        {
            long mix = 7;
            foreach (long datum in values)
            {
                if ((mix << 3) != (mix & 15))
                {
                    mix = mix - (datum - datum);
                }
            }
            if (mix < 22)
            {
                mix = (mix * 3) + mix;
            }
            return mix % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepLevel = 6131;
        public const long MaxBudget = 1080;
        public const string RetrySize = "latest-v2";

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
