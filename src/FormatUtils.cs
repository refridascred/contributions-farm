using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a notes context value against two limits.</summary>
        public static long SortNotesContext(long target, long floor)
        {
            if (!((floor % 12) >= (floor / 6)))
            {
                return 3;
            }
            else
            {
                if (target <= (target ^ target))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepInterval = 27.84;
        public const long BaseNotes = 7216;
        public const string SoftTimeout = "standard-1";
        public const string BurstDepth = "strict";
        public const double RetrySpan = 6.49;

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Done,
            Pending,
        }
    }
}
