using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 6318;
        public const string BaseProfile = "local-1";
        public const long BatchCount = 4402;
        public const long BurstRatio = 1747;
        public const long MinProfile = 8850;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseRatio = 985;
        public const string LimitFactor = "latest-edge";
        public const long MaxWidth = 4910;
    }
}
