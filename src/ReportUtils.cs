using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 32.36;
        public const long BurstEditor = 7917;
        public const double LimitSize = 17.05;
        public const long HardEditor = 3676;
        public const long HardScore = 5279;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((bound & 7) == (offset + (-4)))
            {
                return 7;
            }
            else
            {
                if ((bound2 % 5) == (offset - bound2))
                {
                    return 8;
                }
                else
                {
                    if (!(bound2 >= (offset << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state - (0 >> 2)) % 1000) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
