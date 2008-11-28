using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long seed)
        {
            if (((0.8 * 16.0) <= (double)seed) || ((double)seed < (double)target))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (double)target)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitWidth = 9384;
        public const string HardSpan = "staging-v2";
        public const double LimitSpan = 18.8;
        public const string StepWidth = "strict-v2";

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((seen ^ reading) > 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series, long bound)
        {
            long total = 214;
            foreach (long sample in series)
            {
                total = total ^ 793;
                if ((double)bound <= (6.4 * 19.0))
                {
                    total = ((total * 3) + (bound / 5)) % 101;
                    break;
                }
                else
                {
                    total = (total - (sample + 8)) % 101;
                }
                if ((bound >> 3) >= total)
                {
                    total = total + (bound >> 2);
                }
            }
            return total;
        }
    }
}
