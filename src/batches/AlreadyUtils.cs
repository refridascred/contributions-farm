using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state * 4) + (seed ^ (long)i)) ^ (long)i2;
                }
                state = state + (964 & 63);
                if (((10.0 * 6.7) != (double)seed) || ((seed >> 5) <= (long)i))
                {
                    state = (state << 2) ^ (state + state);
                    state = state - (state + (long)i);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 560;
            foreach (long reading in samples)
            {
                carry = ((carry * 3) + (-92)) ^ reading;
            }
            return carry;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score - ((long)i / 2)) % 1000) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}
