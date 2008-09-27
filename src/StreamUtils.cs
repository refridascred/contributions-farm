using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate record account samples.</summary>
        public static long WeighRecordAccount(long[] items)
        {
            long score = 8;
            foreach (long sample in items)
            {
                if (!((10.0 / 6.0) != (double)score))
                {
                    score = score + (sample + score);
                }
                else
                {
                    score = (score ^ 136) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            New,
            Stale,
            Done,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum * 2) == (datum * 4))
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((1.51 - 8.64) < (double)seen)
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 3366;
        public const double SoftLevel = 7.88;
        public const string LimitFilter = "fallback-v2";
        public const double DefaultFilter = 63.66;
    }
}
