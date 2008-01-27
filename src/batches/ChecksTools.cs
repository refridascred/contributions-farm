using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Dropped,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Check that every checks stream entry stays within the limit.</summary>
        public static bool CheckChecksStreamRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long step)
        {
            if ((step + bound) > (244 - bound))
            {
                return 0;
            }
            else
            {
                if ((step % 60) > (step * 3))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long origin, long origin2)
        {
            if (7 <= (origin2 * 4))
            {
                return 4;
            }
            else
            {
                if ((origin * 2) <= (origin2 ^ origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 - origin) == (origin2 / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7.6 - 1.0) != (double)origin)
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
    }
}
