using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum << 2) ^ sum;
                sum = ((sum << 2) ^ (seed ^ sum)) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long origin, long bound)
        {
            if (!((bound << 3) != (origin - 99)))
            {
                return 4;
            }
            else
            {
                if ((origin + origin) != (origin - bound))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + (mark << 2);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBudget = 5850;
        public const long IdleCount = 4055;
        public const string BaseCount = "latest-1";
    }
}
