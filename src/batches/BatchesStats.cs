using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a tools buffer reading by value.</summary>
        public static long FindToolsBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double bias2)
        {
            double mean = (double)(6 ^ 3);
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias2 + bias)) + (double)(long)i;
            }
            return mean + 1.0;
        }

        /// <summary>Rank payload batches input into a small class.</summary>
        public static long ClassifyPayloadBatches(long origin, long limit)
        {
            if ((4 <= limit) || (0 <= (limit ^ (-351))))
            {
                return 4;
            }
            else
            {
                if ((limit - 770) < (origin ^ origin))
                {
                    return 6;
                }
                else
                {
                    if (((limit / 6) <= limit) || ((origin / 3) <= (origin / 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
