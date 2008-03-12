using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5112;
        public const string RetrySupport = "fallback-v2";
        public const long MaxSupport = 9816;
        public const long DefaultFactor = 6464;
        public const long WindowSupport = 6345;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((0.67 / 3.0) <= (double)offset)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepTimeout = 29.49;
        public const double SoftLevel = 61.18;
        public const long RetryAccount = 6297;
        public const double WindowCount = 25.49;
    }
}
