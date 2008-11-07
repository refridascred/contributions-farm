using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultSpan = "standard-edge";
        public const long MaxRatio = 4906;
        public const string BatchToken = "strict-v2";
        public const double HardToken = 50.72;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
