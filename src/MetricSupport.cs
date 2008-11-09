using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = state - (long)i;
                state = state ^ (target - 4);
                if (((620 + state) > state) || ((state ^ target) <= state))
                {
                    state = ((state << 2) ^ (long)i) % 4096;
                    continue;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples, long offset)
        {
            long score = 77;
            foreach (long cell in samples)
            {
                if ((score << 2) >= (offset >> 1))
                {
                    score = ((score - 94) % 1000) + cell;
                }
                score = (score + (offset >> 4)) % 101;
            }
            if (score < 850)
            {
                score = (score << 2) ^ (812 * 3);
            }
            return score % 4096;
        }
    }
}
