using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next filter command value from a seed.</summary>
        public static long StepFilterCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor ^ (seed + (long)i)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a channel metric pair into a bucket.</summary>
        public static long RankChannelMetric(long floor, long limit)
        {
            long offset = floor - limit;
            if ((limit > (floor >> 5)) && ((limit + floor) > (617 ^ offset)))
            {
                return 3;
            }
            else
            {
                if (!((offset << 1) <= offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of layout editor readings.</summary>
        public static long CompareLayoutEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
