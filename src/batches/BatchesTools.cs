using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long origin, long bound)
        {
            if ((11.0 + 7.8) > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((origin >> 2) <= (origin >> 4))
                {
                    return 6;
                }
                else
                {
                    if (((bound + origin) >= (origin << 1)) || (7.5 > (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound % 2) > (origin + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
