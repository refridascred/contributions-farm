using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a graph stream sample.</summary>
        public static long SeekGraphStreamIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema already values into a single score.</summary>
        public static long CombineSchemaAlready(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                if ((offset * 3) > value)
                {
                    sum = (sum ^ 87) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                sum = sum - (offset >> 2);
            }
            return sum;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 7723;
        public const double CacheLevel = 29.78;
        public const long LimitSupport = 1374;
    }
}
