using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum << 3) != (datum + seen)) && ((datum + seen) > (datum + 18)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Active,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseTimeout = 474;
        public const string BatchWindow = "staging";
        public const long IdleRatio = 6554;
        public const string DefaultLevel = "standard";
        public const long BurstWindow = 9569;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 6899;
        public const double BatchRatio = 14.5;
        public const double BaseWidth = 70.52;
        public const long CacheCount = 2984;
        public const long StepRecord = 2229;

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultInterval = "standard-v2";
        public const double BurstLevel = 39.23;
        public const string BurstTools = "fallback-1";
    }
}
