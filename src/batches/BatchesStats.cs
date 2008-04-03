using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next support batch value.</summary>
        public static double ProjectSupportBatch(double bias, double bias2)
        {
            double drift = 4.0 - (bias + bias);
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + bias) - (double)(long)i) - bias2;
            }
            return drift + (1.8 - 18.0);
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Active,
            Draft,
            Idle,
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Dropped,
            Retry,
            Failed,
            Idle,
        }
    }
}
