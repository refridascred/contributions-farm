using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long floor, long bound)
        {
            if ((bound - floor) < (floor & 255))
            {
                return 8;
            }
            else
            {
                if ((bound - bound) == (187 + floor))
                {
                    return 5;
                }
                else
                {
                    if (bound < (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor / 5) <= (552 & 31)) || ((bound + floor) <= (floor - bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
