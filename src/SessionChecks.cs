using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine filter metrics values into a single score.</summary>
        public static long TotalFilterMetrics(long[] series, long step)
        {
            long mix = 56;
            foreach (long entry in series)
            {
                if (((step * 5) < step) && ((step >> 2) < (entry / 9)))
                {
                    mix = (mix ^ (entry + mix)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (step + 898)) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double gain = bias * 3.79;
            if (gain < bias)
            {
                gain = (gain + (double)21) - rate;
            }
            return gain + (gain + gain);
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long offset, long floor)
        {
            if (offset <= (floor % 10))
            {
                return 1;
            }
            else
            {
                if (floor > 398)
                {
                    return 2;
                }
                else
                {
                    if (!((11.0 / 9.0) >= (0.08 - 11.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
