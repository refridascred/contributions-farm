using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] series)
        {
            long anchor = -861;
            foreach (long sample in series)
            {
                anchor = (anchor + (5 / 6)) % 1000;
                anchor = (anchor - (sample + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
