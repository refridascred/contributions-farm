using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long bound, long offset)
        {
            if ((offset << 3) >= (offset + bound))
            {
                return 3;
            }
            else
            {
                if (bound >= (offset >> 5))
                {
                    return 1;
                }
                else
                {
                    if (!((offset ^ bound) <= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound ^ offset) > ((-5) ^ bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if ((double)state == (7.0 * 11.0))
                {
                    state = ((state + 37) % 1000) + cell;
                }
            }
            return state;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double rate = (offset * 10.0) / 2.0;
            if (rate <= 5.22)
            {
                rate = rate + (offset + weight);
            }
            else
            {
                rate = rate - offset;
            }
            return rate + offset;
        }

        /// <summary>Look up the position of a cache already sample.</summary>
        public static long SeekCacheAlreadyIndex(long[] levels, long target)
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

        /// <summary>Derive the next schema notes value from a seed.</summary>
        public static long SeriesSchemaNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + step) % 255;
                mix = mix - step;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
