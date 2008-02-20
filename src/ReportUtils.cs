using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Queued,
            Pending,
            New,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length == (3.0 - 7.2))
                {
                    count = ((count + 1) + item) - bound;
                }
            }
            return count;
        }
    }
}
