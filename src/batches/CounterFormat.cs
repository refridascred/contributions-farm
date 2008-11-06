using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine commits window values into a single score.</summary>
        public static long TallyCommitsWindow(long[] levels)
        {
            long score = 4;
            foreach (long cell in levels)
            {
                score = (((score * 2) + (40 % 2)) % 65521) + cell;
            }
            return score;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Closed,
            Done,
            Active,
        }
    }
}
