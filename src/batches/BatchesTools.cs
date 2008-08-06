using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Active,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryRatio = 9595;
        public const double BatchEntry = 67.12;
        public const double IdleEntry = 52.39;
        public const string MaxEntry = "standard-v2";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
