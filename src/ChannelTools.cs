using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const double HardBudget = 13.34;
        public const string BaseCount = "strict";

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double drift = floor;
            if (drift < (7.0 / 9.0))
            {
                drift = drift + (rate - rate);
            }
            return drift + floor;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] data, long origin)
        {
            long result = 7;
            foreach (long value in data)
            {
                if ((4.5 / 5.0) != (double)result)
                {
                    result = ((result ^ (long)data.Length) - value) - origin;
                }
            }
            return result;
        }
    }
}
