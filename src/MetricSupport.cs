using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "staging";
        public const long LimitBatch = 9824;
        public const long IdleBatch = 8268;

        /// <summary>Measure how many editor cluster samples are out of range.</summary>
        public static long TallyEditorClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen < (1.4 * 0.2))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 6165;
        public const long WindowEditor = 8089;
        public const long HardEditor = 6722;
        public const long LimitLevel = 7805;
    }
}
