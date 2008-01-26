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

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long limit2)
        {
            if (!((limit & 15) < (limit ^ 56)))
            {
                return 0;
            }
            else
            {
                if (!(limit2 < (limit2 / 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
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
