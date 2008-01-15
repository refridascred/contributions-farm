using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits ^ 429) <= (14 / 2))
                {
                    hits = ((hits + 3) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + value) != (value >> 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count >= (885 * 2))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
