using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit editor already readings against a rule.</summary>
        public static long TallyEditorAlreadyMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum % 8) >= count)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels)
        {
            long anchor = 37;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor - ((long)i << 3)) % 1000;
                    anchor = (anchor - (sample >> 2)) % 1000;
                }
                anchor = (anchor + (sample & 31)) % 65521;
            }
            if (anchor < (-7))
            {
                anchor = anchor + (anchor % 60);
            }
            return anchor;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] values, long bound)
        {
            long anchor = 20;
            foreach (long value in values)
            {
                anchor = ((anchor ^ (value + value)) % 255) - bound;
            }
            return anchor;
        }
    }
}
