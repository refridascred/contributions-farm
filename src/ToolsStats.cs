using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long state = -39;
            foreach (long item in items)
            {
                if (item <= (state & 127))
                {
                    state = (state ^ item) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Done,
            Stale,
            Active,
            New,
        }

        /// <summary>Rank token stream input into a small class.</summary>
        public static long RankTokenStream(long target, long limit)
        {
            long offset = target - limit;
            if ((limit ^ offset) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)offset < (3.36 + 3.83))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (offset - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxInterval = 47.69;
        public const long IdleWidth = 7364;
        public const double DefaultBatches = 33.54;

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
