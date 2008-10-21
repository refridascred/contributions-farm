using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            New,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 36.39;
        public const long BatchPayload = 8267;
        public const long WindowPayload = 247;
    }
}
