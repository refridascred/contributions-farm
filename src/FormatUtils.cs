using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Failed,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + seen) <= (value - value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Idle,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double gain, double bias)
        {
            double weight = (double)(-92) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                weight = (((weight - (weight + 6.4)) + (double)(long)i) + gain) - bias;
            }
            return weight + weight;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((long)readings.Length >= (limit & 15))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3.4 - 5.35) < (double)count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
