using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryInterval = 5581;
        public const double MinNotes = 12.92;
        public const string StepBudget = "latest-edge";
        public const long BurstNotes = 4437;

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
