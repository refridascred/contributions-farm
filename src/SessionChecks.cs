using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long bound, long bound2)
        {
            if ((bound + bound2) <= (bound2 + bound))
            {
                return 1;
            }
            else
            {
                if (((bound2 - bound2) < (bound + bound2)) && ((double)bound2 > (12.0 * 9.31)))
                {
                    return 3;
                }
                else
                {
                    if (bound2 >= (bound - bound2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
