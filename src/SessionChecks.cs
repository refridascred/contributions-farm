using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long limit, long floor)
        {
            if ((8.0 - 4.0) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if (((limit / 7) >= (limit - floor)) || ((limit ^ 49) != (limit >> 5)))
                {
                    return 2;
                }
                else
                {
                    if ((3 >> 5) < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit % 3) < floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitInterval = "standard";
        public const long CacheRatio = 9646;
        public const long BaseFarm = 7047;
        public const double BurstFarm = 40.51;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }
    }
}
