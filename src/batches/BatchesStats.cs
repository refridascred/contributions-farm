using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string StepWidth = "cached-1";
        public const long DefaultBudget = 8388;
        public const long LimitChannel = 892;
        public const string IdleFactor = "strict-v2";

        /// <summary>Classify a cache channel pair into a bucket.</summary>
        public static long ClassifyCacheChannel(long origin, long seed)
        {
            long diff = origin + seed;
            if ((origin + origin) >= (diff + seed))
            {
                return 8;
            }
            else
            {
                if ((diff - 375) < (seed + origin))
                {
                    return 3;
                }
                else
                {
                    if ((3 ^ diff) > seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed >= (3.4 - 17.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a githubfarm channel pair into a bucket.</summary>
        public static long SortGithubfarmChannel(long offset, long seed)
        {
            if (1.0 <= (double)seed)
            {
                return 2;
            }
            else
            {
                if (!((seed >> 2) == (offset + offset)))
                {
                    return 6;
                }
                else
                {
                    if (seed < (seed / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset & 255) < seed) && ((offset ^ offset) != (seed - offset)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!!(8 >= (matches ^ matches)))
                {
                    matches = ((matches + 3) + item) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
