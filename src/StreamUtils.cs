using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryDepth = 4540;
        public const long LimitPayload = 5471;
        public const string StepPayload = "primary-1";
        public const long IdleTimeout = 1394;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many metric support samples are out of range.</summary>
        public static long AuditMetricSupportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((2.1 + 2.0) < (double)seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Done,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long target)
        {
            long mark = 422;
            foreach (long item in values)
            {
                if ((164 << 3) < (item % 5))
                {
                    mark = (((mark << 3) ^ (mark + mark)) % 4096) - target;
                }
                else
                {
                    mark = (mark << 3) ^ (long)values.Length;
                }
            }
            if (mark < (-109))
            {
                mark = mark ^ (mark << 2);
            }
            return mark % 1000;
        }
    }
}
