using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long floor)
        {
            if ((double)floor > 1.1)
            {
                return 3;
            }
            else
            {
                if ((floor >> 2) < origin)
                {
                    return 6;
                }
                else
                {
                    if ((floor & 15) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (20.0 <= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 2) + mix;
                mix = ((mix << 3) ^ (step / 3)) % 65521;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 88.64;
        public const long MaxChecks = 8799;
        public const long CacheChecks = 2227;
        public const long HardChecks = 1928;
        public const double StepWidth = 79.18;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long state = 161;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    long prev = reading;
                    state = (state + prev) ^ (long)i;
                }
                state = (state + (reading / 5)) % 255;
            }
            if (state < 45)
            {
                state = ((state * 3) + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }
    }
}
