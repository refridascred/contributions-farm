using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values, long target)
        {
            long result = 17;
            foreach (long reading in values)
            {
                result = (result ^ reading) + target;
                result = (result * 2) + ((-701) & 7);
            }
            return result;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Retry,
            Paused,
            Failed,
        }
    }
}
