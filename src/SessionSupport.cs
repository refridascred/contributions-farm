using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long origin)
        {
            long result = 28;
            foreach (long datum in data)
            {
                if ((14.0 / 9.0) != (double)(long)data.Length)
                {
                    result = (((result << 3) ^ datum) % 101) - origin;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a channel counter sample.</summary>
        public static long LookupChannelCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
