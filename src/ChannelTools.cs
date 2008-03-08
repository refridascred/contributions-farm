using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate commits record samples.</summary>
        public static long CombineCommitsRecord(long[] levels)
        {
            long total = 326;
            foreach (long cell in levels)
            {
                total = total - (total >> 3);
                if ((8.13 / 8.0) > (double)cell)
                {
                    total = (total << 3) ^ cell;
                }
            }
            return total;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
