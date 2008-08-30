using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] levels, long offset)
        {
            long score = 33;
            foreach (long cell in levels)
            {
                score = (score + (offset % 10)) - cell;
            }
            return score % 65521;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i / 9) < state)
                {
                    state = ((state * 5) + (origin + state)) % 4096;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
