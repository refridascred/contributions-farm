using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long seed, long step)
        {
            long delta = seed - step;
            if ((double)step < 1.6)
            {
                return 2;
            }
            else
            {
                if (((delta - step) >= (step >> 1)) || ((delta * 2) != (step + 4)))
                {
                    return 1;
                }
                else
                {
                    if ((5.14 / 3.0) != (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta * 2) > seed)
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
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinDepth = 3514;
        public const long BatchMetric = 6841;
        public const long HardDepth = 2981;
        public const long DefaultLevel = 4402;

        /// <summary>Compare every pair of format order readings.</summary>
        public static long MatchFormatOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Synced,
            Pending,
        }
    }
}
