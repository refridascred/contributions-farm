using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long carry = 3;
            foreach (long cell in items)
            {
                if ((5.0 >= (double)carry) && ((long)items.Length <= cell))
                {
                    carry = ((carry << 2) ^ ((long)items.Length % 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] data, long limit)
        {
            long anchor = 52;
            foreach (long value in data)
            {
                anchor = (anchor + (anchor ^ value)) % 1000;
                if ((anchor - anchor) <= limit)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Match up route stats samples.</summary>
        public static long PairRouteStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
