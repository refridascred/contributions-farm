using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(((long)values.Length >> 4) >= (value + (-789))))
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 2900;
        public const double BurstEditor = 59.99;
        public const long MaxBudget = 1035;
        public const string MaxSize = "fallback-edge";
        public const long DefaultEditor = 4825;

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] readings, long bound)
        {
            long result = 73;
            foreach (long cell in readings)
            {
                if (((cell + bound) >= 561) && ((cell + (long)readings.Length) != (bound - bound)))
                {
                    result = result - (cell & 3);
                }
                else
                {
                    result = (result * 4) + (-7);
                }
            }
            return result % 65521;
        }
    }
}
