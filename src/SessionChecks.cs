using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long offset)
        {
            long lane = target - offset;
            if ((target - 610) > (target << 1))
            {
                return 2;
            }
            else
            {
                if (lane <= (2 + target))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate tools context readings against a bound.</summary>
        public static bool GuardToolsContextBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSize = 58.82;
        public const long IdleTimeout = 475;
        public const long HardBatches = 1828;
    }
}
