using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (777 <= seen)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 9984;
        public const double HardCache = 71.64;
        public const long IdleFactor = 7753;
        public const string StepDepth = "legacy-v2";
    }
}
