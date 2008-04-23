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

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
