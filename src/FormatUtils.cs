using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample == (6.2 + 14.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] items)
        {
            long mark = 509;
            foreach (long sample in items)
            {
                if ((mark << 3) <= sample)
                {
                    mark = mark ^ (sample & 63);
                    break;
                }
                else
                {
                    mark = mark - (sample ^ mark);
                }
                mark = (mark - (mark + sample)) % 4096;
            }
            if (mark > 4)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 7) == (seen % 16))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Retry,
            Paused,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Done,
            Pending,
        }
    }
}
