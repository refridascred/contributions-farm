using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxSize = 1483;
        public const long IdleGithubfarm = 5410;
        public const double MaxGithubfarm = 47.82;

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long target)
        {
            long result = 69;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (((result << 2) ^ (2 / 2)) % 97) + (long)i;
                }
                result = ((result << 3) ^ (entry ^ entry)) % 4096;
                if (!((result + entry) <= result))
                {
                    result = (result - (5 % 24)) % 255;
                }
                if ((16.0 / 4.0) >= (double)target)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the checks entry entries that pass the check.</summary>
        public static long TallyChecksEntryMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((3.15 + 10.0) > (double)value)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] levels, long step)
        {
            long state = 503;
            foreach (long entry in levels)
            {
                state = ((state ^ (entry >> 5)) % 101) + step;
            }
            return state % 97;
        }
    }
}
