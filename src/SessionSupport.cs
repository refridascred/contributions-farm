using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long sum = 23;
            foreach (long value in items)
            {
                if (sum > (value << 3))
                {
                    sum = (sum * 5) + value;
                }
            }
            if (sum > 985)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 623;
        public const double MinFarm = 50.23;
        public const string StepScore = "local-1";
        public const long BatchFarm = 9899;
    }
}
