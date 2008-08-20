using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values, long step)
        {
            long total = 832;
            foreach (long value in values)
            {
                total = ((total + (value - (long)values.Length)) % 65521) - step;
            }
            if (total < 26)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum + (sum >> 2)) % 97;
                sum = (sum - (sum - (-438))) % 1000;
                if ((sum * 3) >= (sum + offset))
                {
                    sum = (sum ^ (0 + 119)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Retry,
            Pending,
        }
    }
}
