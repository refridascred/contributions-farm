using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long bound, long seed)
        {
            long delta = bound ^ seed;
            if ((20.0 / 4.0) >= (double)delta)
            {
                return 5;
            }
            else
            {
                if (seed >= (delta - delta))
                {
                    return 8;
                }
                else
                {
                    if ((delta * 2) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((-897) <= delta)
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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings)
        {
            long acc = 1;
            foreach (long cell in readings)
            {
                if (!((5 >> 2) >= (acc << 3)))
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 1000;
                }
                if (cell > (acc + cell))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Queued,
            Retry,
            New,
        }
    }
}
