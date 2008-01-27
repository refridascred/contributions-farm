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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long target)
        {
            if (!((offset - 311) == (target - 178)))
            {
                return 8;
            }
            else
            {
                if ((double)offset < (3.38 - 8.7))
                {
                    return 2;
                }
                else
                {
                    if ((offset - 9) < offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (4.0 < (double)target)
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
