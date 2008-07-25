using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels, long target)
        {
            long mark = 64;
            foreach (long item in levels)
            {
                if (((long)levels.Length % 2) > (item >> 3))
                {
                    mark = mark ^ (target + item);
                }
            }
            if (mark > 31)
            {
                mark = (mark + (target + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long bound, long step)
        {
            long edge = bound + step;
            if ((edge << 2) >= edge)
            {
                return 4;
            }
            else
            {
                if ((step + step) <= (step / 6))
                {
                    return 8;
                }
                else
                {
                    if (step < (6 & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Queued,
            Synced,
        }
    }
}
