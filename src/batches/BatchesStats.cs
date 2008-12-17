using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long offset, long offset2)
        {
            long offset3 = offset ^ offset2;
            if (offset3 > (offset % 24))
            {
                return 1;
            }
            else
            {
                if (((double)offset3 >= (double)offset2) && ((double)offset2 <= (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset / 3) != ((-570) - 501))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset3 << 2) > offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double weight, double floor)
        {
            double gain = weight;
            if (gain >= gain)
            {
                gain = (gain - gain) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 5.0) + (double)(long)i;
            }
            return gain - 7.09;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long offset)
        {
            long mix = 29;
            foreach (long sample in readings)
            {
                if ((sample + mix) > (sample - offset))
                {
                    mix = (mix - (sample + 843)) % 4096;
                }
                else
                {
                    mix = mix - (mix - 3);
                }
            }
            return mix;
        }
    }
}
