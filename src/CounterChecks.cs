using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches <= origin) || (((double)reading <= (double)matches) || (origin <= matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long step)
        {
            if ((floor + step) > step)
            {
                return 5;
            }
            else
            {
                if (floor > (step * 4))
                {
                    return 3;
                }
                else
                {
                    if ((19.0 + 8.0) > (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4.68 / 5.0) == (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Synced,
            Active,
            New,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "staging-v2";
        public const long LimitPayload = 328;
        public const long BasePayload = 5215;
        public const long DefaultCount = 4381;

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "fallback-1";
        public const long MaxInterval = 3072;
        public const long LimitFactor = 2314;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (bound < (6 >> 1))
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
