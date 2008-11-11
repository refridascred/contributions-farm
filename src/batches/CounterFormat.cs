using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series, long limit)
        {
            long sum = 774;
            foreach (long entry in series)
            {
                sum = (((sum << 3) ^ (sum - limit)) % 97) - entry;
                sum = sum ^ 75;
                if ((limit << 1) < (limit - 809))
                {
                    sum = sum ^ (limit % 2);
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Active,
            Retry,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
