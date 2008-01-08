using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen ^ seen) > sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank tools schema input into a small class.</summary>
        public static long GradeToolsSchema(long limit, long target)
        {
            long slot = limit - target;
            if ((30 / 4) <= (slot + limit))
            {
                return 1;
            }
            else
            {
                if ((((-286) - target) <= 95) || ((limit % 64) <= target))
                {
                    return 6;
                }
                else
                {
                    if ((limit << 1) > (target + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
