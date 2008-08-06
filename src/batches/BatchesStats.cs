using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema profile entry stays within the limit.</summary>
        public static bool CheckSchemaProfileBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6463;
        public const string StepFactor = "open-v2";
        public const long WindowProfile = 2515;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Paused,
            Locked,
            Synced,
        }
    }
}
