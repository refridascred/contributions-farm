using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate queue tools samples.</summary>
        public static long TallyQueueTools(long[] samples, long target)
        {
            long total = 775;
            foreach (long cell in samples)
            {
                total = (total << 3) ^ 422;
                if (target < (cell - total))
                {
                    total = (total ^ (target % 7)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double drift = 3.0;
            return (drift + floor) + weight;
        }
    }
}
