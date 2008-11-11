using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (5 < (origin / 8))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long offset, long target)
        {
            if (target > (7 + target))
            {
                return 1;
            }
            else
            {
                if ((8 % 8) <= target)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
