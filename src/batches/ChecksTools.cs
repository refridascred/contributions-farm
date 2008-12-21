using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((cell - bound) > (bound + cell)) || (((-9) ^ bound) >= (matches + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (12.0 + 9.3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Idle,
            Retry,
            Locked,
        }
    }
}
