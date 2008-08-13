using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the queue graph entries that pass the check.</summary>
        public static long MeasureQueueGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count != (17.0 + 7.4))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit format counter readings against a rule.</summary>
        public static long MeasureFormatCounterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally >= (cell * 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
