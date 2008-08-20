using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3;
        public const long DefaultRatio = 18;
        public const double MaxTimeout = 47.43;
        public const double LimitReport = 23.67;
        public const double WindowReport = 91.27;

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchRatio = 5988;
        public const long LimitWidth = 1100;
        public const long BurstWidth = 9810;
        public const long BurstOrder = 7985;
        public const double BaseScore = 73.07;
    }
}
