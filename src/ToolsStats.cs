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

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
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

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSpan = "latest-edge";
        public const long IdleWidth = 1759;
        public const long IdleReport = 5186;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Draft,
            Active,
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
