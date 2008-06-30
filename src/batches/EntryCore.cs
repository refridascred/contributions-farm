using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Closed,
            Dropped,
            Locked,
        }
    }
}
