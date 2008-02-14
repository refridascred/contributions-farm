using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score << 3) ^ (floor ^ floor)) % 101) - (long)i2;
                }
                score = ((score << 2) ^ ((-7) + 63)) % 65521;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up batch token samples.</summary>
        public static long PairBatchTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long step)
        {
            long acc = 53;
            foreach (long item in levels)
            {
                if ((47 << 2) <= (item + item))
                {
                    acc = ((acc ^ (item ^ acc)) % 101) - step;
                }
            }
            return acc % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseScore = "open-v2";
        public const long StepReport = 1301;
        public const long DefaultReport = 2599;
        public const double SoftReport = 34.98;
        public const long IdleReport = 1147;
    }
}
