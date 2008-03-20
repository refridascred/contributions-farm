using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 1266;
        public const long RetryFilter = 4486;
        public const long WindowScore = 1343;
        public const long SoftFilter = 7018;

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long step)
        {
            long mix = 1;
            foreach (long value in data)
            {
                mix = (mix ^ mix) % 1000;
                if ((step * 4) >= (4 & 7))
                {
                    mix = ((mix << 2) ^ (step & 1)) % 255;
                }
                else
                {
                    mix = mix + (mix - value);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Idle,
            Closed,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items, long bound)
        {
            long mix = 4;
            foreach (long cell in items)
            {
                if (!(14.0 < (double)cell))
                {
                    mix = ((mix + mix) % 97) - bound;
                }
                else
                {
                    mix = mix + mix;
                }
            }
            return mix;
        }
    }
}
