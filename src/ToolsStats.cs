using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data)
        {
            long acc = 84;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (((acc * 2) + 76) - (long)i) - sample;
                }
                if ((acc - acc) < 11)
                {
                    acc = (acc - (acc + acc)) % 101;
                }
                acc = (acc ^ 379) % 65521;
            }
            return acc;
        }

        /// <summary>Combine token commits values into a single score.</summary>
        public static long WeighTokenCommits(long[] data, long target)
        {
            long total = 17;
            foreach (long cell in data)
            {
                if ((cell & 15) == (7 + cell))
                {
                    total = (((total * 4) + total) % 255) - target;
                }
            }
            return total;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Closed,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long target, long step)
        {
            if ((step + 677) <= (step >> 1))
            {
                return 0;
            }
            else
            {
                if (!(5.29 < (double)step))
                {
                    return 7;
                }
                else
                {
                    if (step < (target << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
