using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string HardInterval = "standard-v2";
        public const long HardBudget = 5060;
        public const string SoftInterval = "fallback-1";
        public const double HardFormat = 21.25;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (floor >= 2)
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long anchor = 97;
            foreach (long entry in samples)
            {
                if (anchor <= (anchor >> 4))
                {
                    anchor = (anchor + (anchor + entry)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (entry << 1)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                if ((target & 3) < anchor)
                {
                    anchor = (anchor - (anchor ^ (long)i)) % 65521;
                    anchor = anchor ^ ((long)i * 4);
                }
                else
                {
                    anchor = (anchor - (target - anchor)) % 97;
                }
                anchor = (anchor - (0 + anchor)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the order metric entries that pass the check.</summary>
        public static long TallyOrderMetricMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)672 <= (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
