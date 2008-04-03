using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (double)(-2))
            {
                ratio = (ratio - (double)645) + floor;
            }
            return ratio + (scale * 9.1);
        }

        /// <summary>Fold a list of farm batch readings.</summary>
        public static long ScoreFarmBatch(long[] series)
        {
            long result = 4;
            foreach (long item in series)
            {
                if ((long)series.Length > (712 / 4))
                {
                    result = ((result ^ (162 & 127)) % 255) - item;
                }
                else
                {
                    result = result + (2 * 2);
                }
            }
            return result % 4096;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long step, long limit)
        {
            if ((step >> 3) >= (limit * 2))
            {
                return 1;
            }
            else
            {
                if (((step + step) != (step + 866)) || ((limit ^ step) != (limit ^ limit)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
