using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardScore = "strict";
        public const long BurstFilter = 8556;
        public const double StepFilter = 77.35;
        public const long DefaultFilter = 5394;
        public const long BatchFilter = 4960;

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            New,
            Closed,
            Dropped,
            Ready,
        }
    }
}
