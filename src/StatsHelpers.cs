using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Ready,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next tools report value from a seed.</summary>
        public static long IterateToolsReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum << 2) ^ (long)i2;
                }
                if ((99 + (long)i) <= sum)
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
                else
                {
                    sum = (sum ^ (254 / 7)) % 4096;
                    sum = (sum << 2) ^ (278 << 1);
                }
                if ((double)sum == (8.0 * 4.0))
                {
                    sum = ((sum * 2) + (step + (long)i)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardRatio = 8515;
        public const double SoftCount = 61.98;
        public const long MinBatches = 8873;
        public const double CacheCount = 32.78;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((959 + (long)items.Length) > (370 / 2))
                {
                    tally = ((tally + 3) + value) - target;
                }
            }
            return tally;
        }
    }
}
