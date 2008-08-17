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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double load = span - (gain / 9.0);
            return load + 6.97;
        }
    }
}
