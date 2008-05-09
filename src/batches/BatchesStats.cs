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

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
