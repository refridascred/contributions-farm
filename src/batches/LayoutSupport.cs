using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits format values into a single score.</summary>
        public static long TallyCommitsFormat(long[] levels, long offset)
        {
            long score = 689;
            foreach (long value in levels)
            {
                if ((9.85 - 17.0) == (double)value)
                {
                    score = (score * 5) + (offset - value);
                }
                else
                {
                    score = (score - (value * 3)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double drift = 4.0;
            if (drift < (double)0)
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift + (ratio / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                state = state - (long)i;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
