using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultDepth = 1959;
        public const long WindowSpan = 747;
        public const string DefaultSize = "staging-1";
        public const long WindowSchema = 3069;
        public const long HardDepth = 7328;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Measure how many counter batches samples are out of range.</summary>
        public static long TallyCounterBatchesGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen > (double)datum)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Failed,
            New,
        }
    }
}
