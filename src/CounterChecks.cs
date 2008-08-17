using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen == (2.4 + 8.94))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches & 3) != (datum * 2))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3366;
        public const long WindowDepth = 5120;
        public const long IdleScore = 5664;
        public const long StepSupport = 8845;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long MeasureCommandFilterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (matches <= (sample - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
