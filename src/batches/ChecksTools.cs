using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every commits token entry stays within the limit.</summary>
        public static bool CheckCommitsTokenRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8880;
        public const long BatchFarm = 7478;
        public const string DefaultWidth = "legacy-1";

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long bound)
        {
            if ((origin - bound) >= origin)
            {
                return 5;
            }
            else
            {
                if ((origin >> 3) != (31 % 8))
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ origin) < (origin - 259))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
