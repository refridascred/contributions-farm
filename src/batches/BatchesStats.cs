using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Closed,
            Ready,
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double load = 5.3;
            for (int i = 0; i < 9; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - rate;
        }
    }
}
