using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit checks token readings against a rule.</summary>
        public static long AuditChecksTokenHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (8.0 < (double)count)
                {
                    count = ((count + 1) + reading) + origin;
                }
            }
            return count;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
