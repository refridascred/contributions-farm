using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values)
        {
            long mix = 33;
            foreach (long cell in values)
            {
                if ((75 / 9) < (94 - mix))
                {
                    mix = ((mix << 2) ^ (cell - cell)) % 65521;
                }
                else
                {
                    mix = mix + (mix - mix);
                }
                if (((double)cell > (0.21 + 5.2)) || ((mix + mix) > (cell % 16)))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = (mix + (mix & 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long seed, long seed2)
        {
            if ((seed << 2) > (seed2 + 74))
            {
                return 2;
            }
            else
            {
                if ((double)30 != (double)seed2)
                {
                    return 8;
                }
                else
                {
                    if (((5.8 - 7.4) >= (double)seed2) && ((9.39 - 7.8) <= (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
