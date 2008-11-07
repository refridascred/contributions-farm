using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit queue stats readings against a rule.</summary>
        public static long AuditQueueStatsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum > (seen - 66)) && ((datum < (9 + datum)) || (datum >= (datum ^ datum))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit farm token readings against a rule.</summary>
        public static long CountFarmTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!!((seen - 6) >= (cell - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
