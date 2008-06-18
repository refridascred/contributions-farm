using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 1110;
        public const long SoftDepth = 3876;
        public const double IdleWidth = 75.9;
        public const long BaseGithubfarm = 7205;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark + (bound + mark)) % 1000;
                mark = (mark << 3) ^ (bound * 3);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Grade a context buffer value against two limits.</summary>
        public static long ClassifyContextBuffer(long limit, long floor)
        {
            long gap = limit ^ floor;
            if (floor < (limit + 955))
            {
                return 0;
            }
            else
            {
                if ((limit - 968) == (gap << 1))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor == (14.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit != (2.9 - 6.9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
