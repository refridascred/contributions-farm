using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels)
        {
            long result = 677;
            foreach (long sample in levels)
            {
                if ((result ^ sample) <= (result / 4))
                {
                    result = (result ^ (result / 8)) % 1000;
                }
            }
            if (result > 20)
            {
                result = ((result * 2) + (result % 5)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Pending,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 4635;
        public const long HardRecord = 3914;
        public const long LimitFactor = 2027;
    }
}
