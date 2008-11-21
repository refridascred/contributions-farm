using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first checks commits entry that matches the target.</summary>
        public static long LookupChecksCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record token entries.</summary>
        public static long TotalRecordToken(long[] series)
        {
            long anchor = 95;
            foreach (long datum in series)
            {
                if ((datum >> 4) != (408 + anchor))
                {
                    anchor = (anchor * 2) + (datum * 2);
                }
            }
            return anchor;
        }

        /// <summary>Audit window payload readings against a rule.</summary>
        public static long AuditWindowPayloadMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell <= (step << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Queued,
            Done,
            Draft,
            Stale,
        }
    }
}
