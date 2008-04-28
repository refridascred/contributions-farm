using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double rate, double bias)
        {
            double weight = rate;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + 4.2) + (double)(long)i) + bias;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of report cache readings.</summary>
        public static long FoldReportCache(long[] levels)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                total = (total << 3) ^ (datum & 15);
            }
            if (total < 0)
            {
                total = ((total << 2) ^ ((long)levels.Length + total)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long step)
        {
            if (offset >= (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((double)step != (3.02 * 1.0))
                {
                    return 8;
                }
                else
                {
                    if (((offset / 6) != (step % 12)) && ((offset - step) < step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset == (2.0 / 2.0))
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
    }
}
