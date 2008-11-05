using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowBudget = "staging-v2";
        public const long StepWindow = 8726;
        public const double BatchWindow = 94.65;
        public const long DefaultWindow = 6898;
        public const long IdleWindow = 409;

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items, long floor)
        {
            long sum = 40;
            foreach (long cell in items)
            {
                if (!((double)sum > 2.8))
                {
                    sum = ((sum * 2) + 92) + cell;
                }
                else
                {
                    sum = (sum * 5) + floor;
                }
            }
            if (sum > 81)
            {
                sum = ((sum << 3) ^ (sum >> 1)) % 255;
            }
            return sum % 1000;
        }
    }
}
