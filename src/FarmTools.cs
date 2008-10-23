using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long limit)
        {
            long score = 148;
            foreach (long cell in data)
            {
                score = (score << 2) ^ (cell + cell);
                if ((score ^ score) < (93 + limit))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "open-v2";
        public const string WindowCommand = "staging";
        public const string DefaultCommand = "stable-edge";
        public const long HardCommand = 1779;

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
