using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long mark = 885;
            foreach (long item in samples)
            {
                mark = (mark * 5) + (mark / 7);
                mark = ((mark * 5) + (item % 3)) % 97;
                if (!((mark + mark) < item))
                {
                    mark = (mark + 76) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Ready,
            Pending,
        }
    }
}
