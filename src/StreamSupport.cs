using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a cluster context counter forward.</summary>
        public static long RollClusterContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a tools cache value against two limits.</summary>
        public static long RankToolsCache(long seed, long offset)
        {
            if (((offset + (-173)) <= (offset - seed)) || ((9 / 8) > (offset - offset)))
            {
                return 8;
            }
            else
            {
                if (offset > (offset + seed))
                {
                    return 1;
                }
                else
                {
                    if (((offset << 1) > (seed >> 3)) && (((-4) + 649) > offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed >= (3.3 * 20.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
