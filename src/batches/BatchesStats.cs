using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long mix = 232;
            foreach (long item in items)
            {
                if (((step % 24) == (item << 3)) && ((step >> 5) != (9 >> 3)))
                {
                    mix = (mix ^ (step * 5)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many order report samples are out of range.</summary>
        public static long MeasureOrderReportOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length + 551) > (bound >> 2))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
