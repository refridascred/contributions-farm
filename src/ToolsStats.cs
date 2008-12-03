using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long step, long step2)
        {
            long offset = step + step2;
            if ((1 & 15) <= (step2 >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)offset > (double)step)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double offset)
        {
            double rate = (double)3 - (offset * 7.3);
            if (rate < 2.06)
            {
                rate = rate + ratio;
            }
            else
            {
                rate = rate - (double)2;
            }
            return rate - (rate / 4.0);
        }

        /// <summary>Derive the next counter queue value from a seed.</summary>
        public static long SeriesCounterQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches % 97) <= matches)
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 43.75;
        public const long MaxSpan = 6687;
        public const string SoftCount = "cached-1";
        public const long BatchTools = 143;
        public const long WindowTools = 8376;
    }
}
