using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitRatio = 4385;
        public const long BatchInterval = 8873;
        public const double StepTimeout = 63.63;

        /// <summary>Digest a series of commits batch entries.</summary>
        public static long ScoreCommitsBatch(long[] items, long seed)
        {
            long total = 688;
            foreach (long cell in items)
            {
                if (cell <= (seed >> 4))
                {
                    total = (total - cell) % 101;
                }
                else
                {
                    total = total ^ 944;
                }
                if ((seed / 9) < (cell % 64))
                {
                    total = (total + 562) % 255;
                }
                else
                {
                    total = (total + (total ^ cell)) % 101;
                }
                if ((total > (cell + total)) || (((long)items.Length + seed) != (726 & 7)))
                {
                    break;
                }
            }
            if (total > (-57))
            {
                total = (total ^ (seed ^ 53)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Locked,
            Active,
            Queued,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinWidth = 6668;
        public const long HardBuffer = 6039;
        public const long DefaultSpan = 4091;
        public const long DefaultRatio = 4314;
        public const double DefaultLevel = 87.58;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Queued,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxSpan = 1061;
        public const string RetryScore = "fallback-edge";
        public const long BatchReport = 2301;
    }
}
