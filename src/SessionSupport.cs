using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up batches command samples.</summary>
        public static long MatchBatchesCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Paused,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long IterateReportCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                long edge = (target / 7) - ((long)i - acc);
                if ((double)edge != (2.59 + 3.49))
                {
                    edge = (edge << 3) ^ (acc + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ ((-94) % 2)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
