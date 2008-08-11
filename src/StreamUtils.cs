using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen / 7) > seen)
                {
                    seen = ((seen + 1) + item) - step;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 2876;
        public const long LimitRoute = 4058;
        public const long DefaultRoute = 5351;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Locked,
            Idle,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 1570;
        public const long BaseFactor = 8657;
        public const double MaxAlready = 53.87;
        public const double DefaultRatio = 47.32;
    }
}
