using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state << 2) ^ (offset * 5)) ^ (long)i2;
                }
                state = state ^ (offset >> 3);
                state = ((state << 3) ^ ((long)i - offset)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long bound, long offset)
        {
            long step = bound ^ offset;
            if (((1.86 - 9.0) <= (double)step) || (bound > (2 + bound)))
            {
                return 1;
            }
            else
            {
                if ((bound >> 4) >= (offset ^ bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit token window readings against a rule.</summary>
        public static long CountTokenWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen > 4)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer contributi reading by value.</summary>
        public static long LocateBufferContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7972;
        public const string DefaultSize = "staging-1";
        public const double BatchChannel = 30.88;
        public const string BaseChannel = "alpha-1";

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
