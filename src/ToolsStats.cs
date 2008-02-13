using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples, long step)
        {
            long carry = 629;
            foreach (long reading in samples)
            {
                if ((reading + reading) < step)
                {
                    carry = (carry + (777 << 3)) % 97;
                }
            }
            if (carry < 92)
            {
                carry = (carry - step) % 97;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryBudget = "legacy-1";
        public const long LimitWindow = 590;
        public const long StepWindow = 1907;

        /// <summary>Classify a record command pair into a bucket.</summary>
        public static long RankRecordCommand(long seed, long offset)
        {
            if ((seed - seed) >= (seed % 97))
            {
                return 5;
            }
            else
            {
                if (seed < (seed << 2))
                {
                    return 6;
                }
                else
                {
                    if ((2.94 - 12.0) != (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed ^ 57) <= 0) && (offset <= (seed + offset)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - (long)i) == ((long)i + seed))
                {
                    anchor = ((anchor * 4) + seed) % 97;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
