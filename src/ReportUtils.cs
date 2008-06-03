using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit filter token readings against a rule.</summary>
        public static long AuditFilterTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)cell > (3.0 + 8.0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue record entries.</summary>
        public static long TallyQueueRecord(long[] samples)
        {
            long mark = 481;
            foreach (long reading in samples)
            {
                if ((reading ^ mark) >= (mark + 2))
                {
                    mark = (mark ^ (reading & 15)) % 1000;
                }
                else
                {
                    mark = ((mark * 5) + (mark >> 2)) % 255;
                }
                if ((mark & 127) < (mark ^ mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
