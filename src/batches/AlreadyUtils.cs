using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseFactor = 6390;
        public const long IdleAlready = 2773;
        public const long DefaultTimeout = 2206;

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)floor == (7.0 + 3.12))
                {
                    score = (score ^ (floor - 99)) % 65521;
                    break;
                }
                else
                {
                    score = (score - floor) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels, long bound)
        {
            long sum = 2;
            foreach (long reading in levels)
            {
                if ((double)reading <= (double)89)
                {
                    sum = ((sum << 3) ^ (sum - bound)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((limit ^ cell) > (95 % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
