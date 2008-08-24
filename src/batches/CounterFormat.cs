using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step + step) == (state + 14))
                {
                    state = (state * 3) + (state - step);
                    break;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Locked,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] data, long offset)
        {
            long total = -194;
            foreach (long sample in data)
            {
                if (total > (sample + total))
                {
                    total = ((total + ((long)data.Length & 1)) % 255) + offset;
                }
            }
            return total % 1000;
        }
    }
}
