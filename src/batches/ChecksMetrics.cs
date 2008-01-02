using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum < (double)3))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Paused,
            Locked,
            Done,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit counter batch readings against a rule.</summary>
        public static long TallyCounterBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + count) != (datum % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout channel samples are out of range.</summary>
        public static long TallyLayoutChannelGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((offset ^ item) != (offset % 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen > (56 + seed))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
