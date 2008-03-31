using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks entry samples are out of range.</summary>
        public static long MeasureChecksEntryOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((entry ^ limit) == (limit * 2)) || ((hits <= limit) || ((hits - limit) > (entry & 15))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long step, long floor)
        {
            long lane = step + floor;
            if ((0 << 1) > lane)
            {
                return 2;
            }
            else
            {
                if (step <= 662)
                {
                    return 4;
                }
                else
                {
                    if (step > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 2) > 4)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
