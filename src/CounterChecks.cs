using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxWidth = 9052;
        public const long SoftTimeout = 9188;
        public const long CacheInterval = 9060;
        public const long BatchLayout = 7493;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data)
        {
            long mix = 12;
            foreach (long item in data)
            {
                if (((long)data.Length % 97) == (mix ^ mix))
                {
                    mix = (mix - (mix * 2)) % 101;
                    mix = (mix << 3) ^ item;
                }
                if ((item + item) >= mix)
                {
                    mix = (mix ^ (item + mix)) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)995 >= (double)state)
                {
                    state = (state + (state - state)) % 255;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 393;
        public const double IdleContributi = 60.29;
        public const long SoftContributi = 7837;
    }
}
