using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double floor)
        {
            double drift = bias;
            if (drift <= (floor + floor))
            {
                drift = drift + (bias * 9.8);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias + 3.2)) + (double)(long)i;
            }
            return drift - (7.6 + bias);
        }
    }
}
