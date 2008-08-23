using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long step)
        {
            long bound2 = bound + step;
            if ((double)bound2 != (6.3 - 0.64))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound2 << 1))
                {
                    return 4;
                }
                else
                {
                    if (((step + bound2) > (bound2 / 4)) || (bound < (bound % 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) < (62 % 10))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Active,
            Done,
            Pending,
        }

        /// <summary>Accumulate contributi checks samples.</summary>
        public static long CombineContributiChecks(long[] items, long target)
        {
            long acc = -30;
            foreach (long value in items)
            {
                acc = (((acc * 2) + (target + target)) % 101) - value;
            }
            if (acc < (-29))
            {
                acc = (acc + acc) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Validate context contributi readings against a bound.</summary>
        public static bool CheckContextContributiBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
