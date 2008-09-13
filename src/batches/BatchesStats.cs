using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            Locked,
            New,
            Idle,
        }

        /// <summary>Audit payload format readings against a rule.</summary>
        public static long AuditPayloadFormatMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally <= (double)item)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!((offset + anchor) <= (anchor - 229)))
                {
                    anchor = anchor - (offset * 2);
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
