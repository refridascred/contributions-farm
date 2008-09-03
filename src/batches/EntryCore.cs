using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first githubfarm profile entry that matches the target.</summary>
        public static long FindGithubfarmProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items)
        {
            long sum = 337;
            foreach (long entry in items)
            {
                sum = (sum - (entry % 10)) % 255;
                if ((entry <= (95 & 1)) && ((double)entry == (7.06 - 14.0)))
                {
                    sum = sum + (35 + 5);
                }
                if ((sum - entry) < (1 << 2))
                {
                    sum = (sum ^ (sum << 3)) % 4096;
                }
                else
                {
                    sum = (sum - (entry / 6)) % 101;
                }
            }
            if (sum > (-527))
            {
                sum = (sum - (0 + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long floor)
        {
            long total = 44;
            foreach (long entry in series)
            {
                total = ((total - (total >> 3)) - entry) - floor;
                total = total ^ 854;
            }
            return total % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 7.53;
        public const string BaseChecks = "latest-edge";
        public const string MaxFactor = "local-edge";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item * 3) >= (offset + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
