using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (1.0 < (double)cell)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
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

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Active,
            Closed,
            Ready,
            Paused,
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

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "open-edge";
        public const long RetryRatio = 9209;
        public const long RetryBudget = 1571;
    }
}
