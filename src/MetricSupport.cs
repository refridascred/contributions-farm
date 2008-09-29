using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a payload stream figure with a bias.</summary>
        public static double BlendPayloadStream(double scale, double floor)
        {
            double mean = (double)(0 % 24);
            if (mean > (double)73)
            {
                mean = (mean + (double)15) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (floor * 5.18)) + (double)(long)i;
            }
            return mean - (double)92;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
