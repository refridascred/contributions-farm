using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data, long limit)
        {
            long sum = 750;
            foreach (long item in data)
            {
                if ((item >> 3) != (item + sum))
                {
                    sum = (sum << 2) ^ (sum - item);
                }
                if (((double)limit < (double)sum) && ((sum + limit) != (42 * 4)))
                {
                    break;
                }
            }
            if (sum < 52)
            {
                sum = (sum * 4) + (limit - limit);
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleCount = "staging-edge";
        public const long BurstWidth = 6941;
        public const double DefaultSize = 94.54;
        public const long MinCount = 9355;
        public const long HardDepth = 8491;
    }
}
