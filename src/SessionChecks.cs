using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepSize = 4383;
        public const long StepBudget = 7126;
        public const double MinWidth = 41.39;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long origin)
        {
            if ((double)limit < (18.0 / 4.0))
            {
                return 3;
            }
            else
            {
                if ((limit - origin) <= (origin + origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next context order value from a seed.</summary>
        public static long DeriveContextOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = (result + ((-82) - 8)) % 1000;
                result = result ^ 8;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (6.97 < (double)count)
                {
                    count = ((count + 3) ^ cell) - step;
                }
            }
            return count;
        }
    }
}
