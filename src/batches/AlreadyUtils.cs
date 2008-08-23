using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a report payload value against two limits.</summary>
        public static long ClassifyReportPayload(long seed, long limit)
        {
            if ((5.92 * 3.1) == (double)seed)
            {
                return 0;
            }
            else
            {
                if (!((limit + 0) <= limit))
                {
                    return 7;
                }
                else
                {
                    if (limit < (seed << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
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
