using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length > (2.0 + 4.7))
                {
                    tally = ((tally + 1) + value) + step;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a notes cluster value against two limits.</summary>
        public static long ClassifyNotesCluster(long target, long seed)
        {
            if ((5.84 + 3.3) == (double)target)
            {
                return 4;
            }
            else
            {
                if (seed > target)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Failed,
            Closed,
            Stale,
            Active,
        }
    }
}
