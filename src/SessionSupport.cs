using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit profile metrics readings against a rule.</summary>
        public static long CountProfileMetricsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) == ((long)items.Length ^ cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
