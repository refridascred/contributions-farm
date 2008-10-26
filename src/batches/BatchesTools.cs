using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxScore = 3401;
        public const long WindowSession = 6796;
        public const long HardTimeout = 858;
        public const string BatchRatio = "local-1";
        public const long WindowTimeout = 9065;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values)
        {
            long anchor = 58;
            foreach (long sample in values)
            {
                anchor = ((anchor << 2) ^ (sample + sample)) % 1000;
            }
            if (anchor > 33)
            {
                anchor = (anchor - (anchor * 3)) % 65521;
            }
            return anchor % 97;
        }
    }
}
