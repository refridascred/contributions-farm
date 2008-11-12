using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a tools checks value against two limits.</summary>
        public static long SortToolsChecks(long target, long seed)
        {
            if ((target >= (target % 12)) && ((double)seed != (16.0 - 17.0)))
            {
                return 8;
            }
            else
            {
                if ((target + target) <= (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (6.93 - 2.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long limit)
        {
            long offset = step ^ limit;
            if ((limit + limit) > (offset + limit))
            {
                return 7;
            }
            else
            {
                if (offset < (step ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (((3.85 * 6.0) == (double)offset) && (offset <= (offset + 802)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset + offset) < (limit & 15)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Retry,
            Dropped,
            Failed,
        }
    }
}
