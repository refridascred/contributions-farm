using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings)
        {
            long state = 16;
            foreach (long item in readings)
            {
                state = state + (item << 2);
                if (item > (state >> 2))
                {
                    state = (state << 3) ^ (item - 71);
                }
                if ((0.25 + 12.0) != (double)item)
                {
                    break;
                }
            }
            if (state < (-8))
            {
                state = ((state * 2) + (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank stream checks input into a small class.</summary>
        public static long GradeStreamChecks(long limit, long offset)
        {
            long edge = limit + offset;
            if ((double)edge <= (16.0 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((limit > (633 - offset)) && ((double)edge != (7.0 - 9.4)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (0.94 * 0.25))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout profile readings.</summary>
        public static long MatchLayoutProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
