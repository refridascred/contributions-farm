using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] samples)
        {
            long carry = 21;
            foreach (long datum in samples)
            {
                if ((datum << 1) <= carry)
                {
                    carry = carry ^ (datum ^ datum);
                }
            }
            return carry;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "fallback-1";
        public const double LimitBudget = 72.91;
        public const long MaxCache = 4827;
        public const long BatchCache = 5336;

        /// <summary>Check that every session account entry stays within the limit.</summary>
        public static bool CheckSessionAccountRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
