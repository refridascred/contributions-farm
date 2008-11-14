using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long origin, long step)
        {
            long next = origin + step;
            if (((origin >> 1) != (origin << 2)) || ((next % 100) > origin))
            {
                return 6;
            }
            else
            {
                if ((origin & 31) == (step - 771))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= 3.0)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            New,
            Failed,
            Active,
        }
    }
}
