using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit editor contributi readings against a rule.</summary>
        public static long AuditEditorContributiGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (2.84 >= (double)seed)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer batches readings against a bound.</summary>
        public static bool GuardBufferBatchesRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally + tally) > floor)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 3870;
        public const long CacheContext = 8763;
        public const long BurstContext = 3562;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double weight, double offset)
        {
            double rate = 5.6;
            if (rate > offset)
            {
                rate = (rate + (1.18 * 6.22)) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)3;
        }
    }
}
