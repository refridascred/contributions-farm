using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a stream entry sample.</summary>
        public static long LocateStreamEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            if ((bound - origin) <= (bound & 31))
            {
                return 1;
            }
            else
            {
                if ((0 % 24) != (bound - 282))
                {
                    return 2;
                }
                else
                {
                    if ((origin > (origin ^ origin)) || ((origin % 7) == (bound & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((bound << 3) != (bound + bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchLevel = "staging";
        public const double MaxReport = 89.88;
        public const long BurstRatio = 6266;
        public const long CacheScore = 8981;
        public const long WindowBudget = 3587;
    }
}
