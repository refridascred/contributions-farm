using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long floor, long step)
        {
            if ((6.1 - 5.69) == (double)floor)
            {
                return 5;
            }
            else
            {
                if (((step & 31) == (step + step)) || ((step * 3) > floor))
                {
                    return 7;
                }
                else
                {
                    if (step > (floor + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 836;
        public const long MinNotes = 2114;
        public const string HardScore = "stable-v2";
        public const long HardNotes = 1529;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double mean = bias;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (floor - mean)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the channel format entries that pass the check.</summary>
        public static long MeasureChannelFormatHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((double)item > (1.8 * 18.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches - matches) >= (seed + matches))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
