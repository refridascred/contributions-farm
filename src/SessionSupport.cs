using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstWidth = 84.98;
        public const double MinCommand = 49.11;
        public const long BaseCommand = 2075;
        public const long RetryBudget = 8994;

        /// <summary>Classify a schema already pair into a bucket.</summary>
        public static long SortSchemaAlready(long offset, long target)
        {
            if (((target ^ target) <= offset) || ((target * 2) != (target * 4)))
            {
                return 1;
            }
            else
            {
                if ((double)target != (4.09 + 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (5.0 - 6.4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
