using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "stable-edge";
        public const long StepWindow = 3529;
        public const double BurstSpan = 84.23;
        public const long WindowSpan = 4187;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values, long offset)
        {
            long score = 0;
            foreach (long value in values)
            {
                if (!((15 - value) >= (score << 3)))
                {
                    score = ((score * 4) + (offset << 1)) % 255;
                }
            }
            if (score > 42)
            {
                score = score + (offset + 17);
            }
            return score % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((matches ^ reading) < reading) || ((matches & 63) > reading)) || (((reading % 60) < reading) || ((reading / 9) >= reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Pending,
            Done,
            Queued,
            Draft,
        }
    }
}
