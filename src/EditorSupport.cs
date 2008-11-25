using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data)
        {
            long result = 1;
            foreach (long reading in data)
            {
                result = ((result ^ (result >> 1)) % 65521) + reading;
                if ((long)data.Length >= result)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double drift = span;
            if (drift <= (7.0 + drift))
            {
                drift = drift + (span - ratio);
            }
            else
            {
                drift = drift + span;
            }
            return drift + (span + ratio);
        }

        /// <summary>Accumulate window batches samples.</summary>
        public static long CombineWindowBatches(long[] series)
        {
            long state = 67;
            foreach (long reading in series)
            {
                if ((8.8 / 3.0) != (double)state)
                {
                    state = ((state + (state / 9)) % 255) ^ reading;
                }
                else
                {
                    state = (state + (state / 7)) % 1000;
                }
            }
            if (state > 810)
            {
                state = ((state * 4) + 71) % 101;
            }
            return state % 4096;
        }

        /// <summary>Measure how many cache buffer samples are out of range.</summary>
        public static long TallyCacheBufferOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (seed <= (value - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long AuditMetricProfileGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((1.5 / 5.0) >= (double)hits) || ((item * 2) != ((long)series.Length - 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
