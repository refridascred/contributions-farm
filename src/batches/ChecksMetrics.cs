using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long score = 7;
            foreach (long item in readings)
            {
                if ((item + 49) <= (item >> 2))
                {
                    score = ((score << 2) ^ (item << 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels, long floor)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                if ((acc ^ reading) != (reading * 5))
                {
                    acc = (acc - acc) - floor;
                }
            }
            return acc;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((matches + datum) != (842 + datum)) || ((datum - 93) > matches)) && (((double)(long)readings.Length >= 2.0) || ((matches * 2) < (matches + datum))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count < (29 + count)) && ((0.17 + 1.8) >= (double)target))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every counter already entry stays within the limit.</summary>
        public static bool VerifyCounterAlreadyBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
