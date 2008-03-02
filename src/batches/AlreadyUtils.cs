using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long offset, long seed)
        {
            if (seed > offset)
            {
                return 0;
            }
            else
            {
                if (seed <= (seed ^ seed))
                {
                    return 6;
                }
                else
                {
                    if ((-159) > (offset + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum * 5) + (long)i) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 554;
        public const string RetrySpan = "open-1";
        public const double LimitAccount = 98.44;
        public const long BatchWidth = 7264;
        public const long HardTimeout = 6556;
    }
}
