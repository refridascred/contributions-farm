using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Dropped,
            Stale,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double offset)
        {
            double mean = offset;
            if (mean > 16.0)
            {
                mean = (mean - (offset + mean)) + scale;
            }
            return mean + (mean - 17.0);
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
