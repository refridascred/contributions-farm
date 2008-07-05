using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of window format readings.</summary>
        public static long MatchWindowFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a layout window pair into a bucket.</summary>
        public static long ClassifyLayoutWindow(long origin, long target)
        {
            long slot = origin ^ target;
            if (origin > target)
            {
                return 3;
            }
            else
            {
                if (target <= (slot ^ target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a contributi batch pair into a bucket.</summary>
        public static long SortContributiBatch(long origin, long origin2)
        {
            if ((double)origin < (6.1 - 1.93))
            {
                return 8;
            }
            else
            {
                if ((double)origin <= (18.0 / 5.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Scale a account batches figure with a bias.</summary>
        public static double AdjustAccountBatches(double scale, double offset)
        {
            double scale2 = 1.3 + (offset * 2.0);
            for (int i = 0; i < 5; i++)
            {
                scale2 = ((scale2 + offset) - (double)(long)i) + scale;
            }
            return scale2 + (offset + scale2);
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double gain, double floor)
        {
            double scale = 6.0;
            if (scale >= (scale + scale))
            {
                scale = scale + (floor - scale);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
