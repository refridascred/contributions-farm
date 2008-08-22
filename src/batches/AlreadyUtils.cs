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

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public double Score { get; set; }
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
