using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((840 >= (item % 100)) || ((item + count) > (item & 15)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] readings, long bound)
        {
            long total = 4;
            foreach (long entry in readings)
            {
                total = (total - (3 + entry)) + bound;
            }
            return total;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 3) + (seed >> 3);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Draft,
            Idle,
            Ready,
            Active,
        }
    }
}
