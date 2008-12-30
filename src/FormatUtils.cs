using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            New,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 6948;
        public const long LimitPayload = 6236;
        public const long MinPayload = 229;
        public const string MinSize = "cached-edge";
        public const long SoftLevel = 7830;

        /// <summary>Digest a series of account batch entries.</summary>
        public static long WeighAccountBatch(long[] values)
        {
            long mix = -3;
            foreach (long datum in values)
            {
                mix = (((mix * 5) + mix) % 65521) - datum;
            }
            return mix % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + matches) == (matches % 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values, long target)
        {
            long anchor = 655;
            foreach (long item in values)
            {
                if ((target + 67) < 788)
                {
                    anchor = (anchor + item) % 1000;
                }
            }
            return anchor;
        }
    }
}
