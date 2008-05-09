using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double rate, double bias)
        {
            double scale = bias + (6.0 / 4.0);
            if (scale < bias)
            {
                scale = (scale - 5.1) - rate;
            }
            else
            {
                scale = scale + (scale * 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (2.9 * 8.0)) + (double)(long)i;
            }
            return scale - (scale * 3.1);
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double drift = (offset * 5.74) + ratio;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 8.0)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((double)datum == (7.2 + 2.65)) || ((58 - (long)data.Length) < (datum ^ datum))) && (hits <= datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a entry support sample.</summary>
        public static long FindEntrySupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
