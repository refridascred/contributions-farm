using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] data)
        {
            long result = 95;
            foreach (long entry in data)
            {
                if (!((entry % 2) <= 33))
                {
                    result = ((result << 2) ^ (entry + result)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double load = span - (gain / 9.0);
            return load + 6.97;
        }
    }
}
