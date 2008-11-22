using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a order batches value against two limits.</summary>
        public static long BucketOrderBatches(long offset, long origin)
        {
            long delta = offset - origin;
            if ((double)offset >= (3.8 - 2.2))
            {
                return 8;
            }
            else
            {
                if (offset < (delta - origin))
                {
                    return 4;
                }
                else
                {
                    if (((-92) % 24) < (delta ^ delta))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset != (3.4 - 7.1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long seed)
        {
            long offset = origin + seed;
            if (((seed ^ origin) >= offset) || ((origin + offset) > 108))
            {
                return 4;
            }
            else
            {
                if ((seed - (-10)) < (seed - offset))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed >> 3) < (seed & 1))
                        {
                            return 6;
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
