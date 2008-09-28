using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Queued,
            Done,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items)
        {
            long mark = -209;
            foreach (long reading in items)
            {
                if (!((reading >> 2) < 0))
                {
                    break;
                }
                if ((mark & 31) <= (reading - reading))
                {
                    mark = (mark << 2) ^ (reading + (-80));
                }
            }
            return mark;
        }

        /// <summary>Combine checks channel values into a single score.</summary>
        public static long FoldChecksChannel(long[] items)
        {
            long mark = 76;
            foreach (long entry in items)
            {
                mark = (mark + (mark ^ entry)) % 4096;
                if ((entry ^ entry) < (mark ^ mark))
                {
                    mark = (mark - entry) % 65521;
                }
            }
            if (mark > 141)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark;
        }
    }
}
