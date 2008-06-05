using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long seed, long origin)
        {
            if ((804 + origin) < 0)
            {
                return 7;
            }
            else
            {
                if (((origin - origin) == ((-96) + 68)) || ((seed * 3) != (seed - origin)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((5 + cell) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Draft,
            Ready,
        }
    }
}
