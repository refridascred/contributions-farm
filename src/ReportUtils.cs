using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every schema route entry stays within the limit.</summary>
        public static bool ValidateSchemaRouteRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "open-edge";
        public const long RetryDepth = 4155;
        public const string HardBudget = "primary-edge";

        /// <summary>Measure how many record counter samples are out of range.</summary>
        public static long CountRecordCounterMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample % 2) < (seen - (long)series.Length)) || ((offset + seen) == (sample - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading * 2) != (step + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
