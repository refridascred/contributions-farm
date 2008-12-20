using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double bias2)
        {
            double rate = bias2 + (bias / 6.0);
            if (rate > (rate + rate))
            {
                rate = rate + (4.32 / 7.0);
            }
            return rate + (bias2 / 2.0);
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Grade a metric format value against two limits.</summary>
        public static long GradeMetricFormat(long seed, long offset)
        {
            long next = seed + offset;
            if ((seed / 2) >= (offset / 4))
            {
                return 5;
            }
            else
            {
                if ((2.63 / 2.0) < (double)next)
                {
                    return 6;
                }
                else
                {
                    if ((775 >> 2) < next)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(seed < offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
