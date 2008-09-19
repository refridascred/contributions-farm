using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (1.4 * 3.2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Locked,
            Draft,
            New,
            Synced,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Closed,
            Ready,
            New,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long floor)
        {
            if (((floor << 2) < (floor % 10)) && ((27 - step) >= step))
            {
                return 8;
            }
            else
            {
                if ((0.8 >= (5.5 + 10.0)) && ((5.4 / 6.0) > (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((step * 4) >= (floor - 607))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
