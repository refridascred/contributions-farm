using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Done,
            Dropped,
            New,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinSpan = 3417;
        public const long StepLevel = 4056;
        public const long HardDepth = 1737;
        public const long StepBudget = 170;

        /// <summary>Look up the position of a notes token sample.</summary>
        public static long LookupNotesTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
