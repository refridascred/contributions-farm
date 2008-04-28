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

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
