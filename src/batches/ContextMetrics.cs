using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 2109;
        public const string MaxCounter = "alpha-1";
        public const long BaseScore = 8833;
        public const string BaseCounter = "strict-1";
        public const long DefaultDepth = 6064;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > bias)
            {
                bias3 = bias3 - (5.4 - bias3);
            }
            else
            {
                bias3 = bias3 - 3.0;
            }
            return bias3 - bias2;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }
    }
}
