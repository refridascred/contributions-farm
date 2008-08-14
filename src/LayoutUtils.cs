using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Count the editor support entries that pass the check.</summary>
        public static long MeasureEditorSupportOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((1.5 * 3.0) != (double)(long)values.Length))
                {
                    hits = ((hits + 1) - value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long diff = step - seed;
            if ((364 << 2) <= seed)
            {
                return 3;
            }
            else
            {
                if ((step >> 1) > (85 - step))
                {
                    return 4;
                }
                else
                {
                    if (!((diff & 7) <= (diff * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
