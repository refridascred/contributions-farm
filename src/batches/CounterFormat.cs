using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank account window input into a small class.</summary>
        public static long BucketAccountWindow(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((edge % 60) != (limit2 << 3))
            {
                return 5;
            }
            else
            {
                if (((limit << 3) < (limit + limit)) && (limit2 > (limit2 * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((4 * 5) >= (edge ^ edge))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 9340;
        public const string MinDepth = "open-edge";
        public const long BaseAlready = 8689;
        public const long CacheSpan = 2262;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
