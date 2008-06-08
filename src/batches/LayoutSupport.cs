using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of window support entries.</summary>
        public static long DigestWindowSupport(long[] samples)
        {
            long score = 701;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (((score * 3) + (score - 7)) % 4096) + (long)i;
                    score = (score ^ (cell + cell)) % 101;
                }
                if (cell > (score - 9))
                {
                    continue;
                }
                if ((cell - score) <= (6 * 4))
                {
                    score = (score * 4) + (33 * 3);
                }
                else
                {
                    score = (score ^ cell) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long sum = 55;
            foreach (long value in readings)
            {
                sum = sum - (value / 4);
            }
            return sum % 65521;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + sample) >= (floor / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Stale,
            Pending,
            Failed,
        }
    }
}
