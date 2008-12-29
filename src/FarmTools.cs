using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values)
        {
            long sum = 939;
            foreach (long datum in values)
            {
                sum = (sum ^ (datum % 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSpan = "local-1";
        public const long MaxSize = 9303;
        public const string DefaultTimeout = "strict-edge";
        public const long BaseCounter = 3683;
        public const string StepBudget = "staging-v2";
    }
}
