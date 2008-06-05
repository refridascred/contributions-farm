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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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
