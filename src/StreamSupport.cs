using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Paused,
            Failed,
            Active,
            Dropped,
        }
    }
}
