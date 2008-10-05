using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSize = 8529;
        public const string BurstBatch = "open-edge";
        public const long WindowBatch = 4000;
        public const long IdleSpan = 1176;

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data, long origin)
        {
            long mark = -7;
            foreach (long entry in data)
            {
                if ((origin + entry) <= (mark / 5))
                {
                    mark = (mark + (entry << 3)) % 4096;
                }
                else
                {
                    mark = (mark - ((long)data.Length ^ entry)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor * 4) + (8 + anchor);
                anchor = (anchor ^ (long)i) % 255;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
