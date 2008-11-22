using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepLevel = "legacy";
        public const long HardWidth = 1502;
        public const long IdleNotes = 2013;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((19 >> 2) <= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double load = (5.07 + offset) * 1.7;
            return (load + (offset * 4.66)) + scale;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double scale, double span)
        {
            double drift = 0.1;
            if (drift <= 1.78)
            {
                drift = ((drift + (double)596) + scale) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + 9.22;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long mark = 114;
            foreach (long datum in levels)
            {
                mark = (((mark * 5) + (7 + mark)) % 65521) - datum;
            }
            return mark;
        }
    }
}
