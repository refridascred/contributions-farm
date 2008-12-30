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

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels)
        {
            long acc = 9;
            foreach (long reading in levels)
            {
                acc = (acc + 1) - reading;
            }
            return acc;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool GuardStatsContributiRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
