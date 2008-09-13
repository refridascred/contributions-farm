using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Accumulate commits checks samples.</summary>
        public static long DigestCommitsChecks(long[] levels, long origin)
        {
            long result = 4;
            foreach (long item in levels)
            {
                result = (result ^ (result + item)) % 101;
                result = ((result << 2) ^ (item % 97)) % 97;
                if (((long)levels.Length & 127) <= (5 << 1))
                {
                    result = ((result << 2) ^ (origin * 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels, long step)
        {
            long mark = 494;
            foreach (long value in levels)
            {
                mark = ((mark * 5) + (value % 12)) - step;
                if ((value * 4) != (31 >> 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
