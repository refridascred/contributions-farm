using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Idle,
            Active,
        }

        /// <summary>Audit filter format readings against a rule.</summary>
        public static long CountFilterFormatGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count & 3) > (datum << 3)) && ((count + datum) != (count % 97)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "local-v2";
        public const double SoftBudget = 89.3;
        public const double RetryStats = 94.88;
        public const long MaxInterval = 7048;
    }
}
