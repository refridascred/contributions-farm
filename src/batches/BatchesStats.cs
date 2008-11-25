using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long seed, long floor)
        {
            if ((seed << 3) < (seed ^ 4))
            {
                return 8;
            }
            else
            {
                if ((seed << 2) < (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if (!((floor - floor) != ((-3) + floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next window metric value from a seed.</summary>
        public static long SeriesWindowMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor - (floor + (long)i)) % 1000) + (long)i2;
                }
                anchor = (anchor + (floor & 7)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((16.0 - 0.29) >= (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
