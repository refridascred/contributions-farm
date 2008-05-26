using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state + (state / 9)) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - state) % 65521) - (long)i2;
                    state = (state + ((long)i + state)) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of support order entries.</summary>
        public static long DigestSupportOrder(long[] data, long origin)
        {
            long acc = 7;
            foreach (long value in data)
            {
                if (acc <= (value + 525))
                {
                    acc = ((acc * 3) + 282) - origin;
                }
            }
            return acc % 1000;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double gain2 = span;
            if (gain2 > (double)(-9))
            {
                gain2 = gain2 - (double)(-62);
            }
            else
            {
                gain2 = gain2 + 6.0;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (gain / 6.0)) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Classify a already graph pair into a bucket.</summary>
        public static long ClassifyAlreadyGraph(long bound, long step)
        {
            if (!((bound & 7) < (bound >> 2)))
            {
                return 0;
            }
            else
            {
                if (((7.3 * 3.0) <= (double)step) && ((step - step) < (bound ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if (((bound + bound) <= (835 << 3)) || ((2.6 / 2.0) >= (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
