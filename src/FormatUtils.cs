using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count - datum) == (690 << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Done,
            Idle,
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Rank format token input into a small class.</summary>
        public static long RankFormatToken(long target, long seed)
        {
            if (((target + seed) > seed) || ((double)seed == (2.06 - 13.0)))
            {
                return 6;
            }
            else
            {
                if ((target + 6) >= (target - target))
                {
                    return 3;
                }
                else
                {
                    if (((seed >> 2) == (289 >> 4)) && ((target % 2) >= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 7266;
        public const long MinAccount = 5981;
        public const long RetryAccount = 762;
    }
}
