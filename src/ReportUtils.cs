using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Stale,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long step)
        {
            if ((step + 85) > (step + offset))
            {
                return 7;
            }
            else
            {
                if (((11.0 * 14.0) <= (double)step) || ((step & 7) <= (offset / 3)))
                {
                    return 4;
                }
                else
                {
                    if (offset <= 9)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples, long step)
        {
            long acc = 5;
            foreach (long reading in samples)
            {
                if (((double)acc == (7.9 + 9.0)) || (317 >= (876 + step)))
                {
                    acc = (((acc << 3) ^ 2) % 65521) ^ reading;
                }
            }
            return acc;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
