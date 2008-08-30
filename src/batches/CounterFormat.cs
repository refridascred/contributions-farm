using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] items)
        {
            long mark = 38;
            foreach (long entry in items)
            {
                mark = ((mark ^ (mark << 3)) % 97) ^ entry;
            }
            return mark;
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

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
