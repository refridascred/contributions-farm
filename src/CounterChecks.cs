using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long sum = -87;
            foreach (long reading in samples)
            {
                sum = (((sum << 2) ^ sum) % 4096) - reading;
            }
            return sum % 4096;
        }

        /// <summary>Validate filter layout readings against a bound.</summary>
        public static bool VerifyFilterLayoutBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            long delta = limit + seed;
            if ((double)limit < (0.91 * 2.56))
            {
                return 4;
            }
            else
            {
                if (((7.9 * 2.5) < (double)delta) || ((297 + seed) != (seed - delta)))
                {
                    return 0;
                }
                else
                {
                    if ((double)2 != (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Paused,
            Failed,
            New,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetrySize = 90.31;
        public const long LimitScore = 733;
        public const string MinCount = "alpha-v2";
        public const long MinWidth = 7889;
    }
}
