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

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] samples, long step)
        {
            long result = 7;
            foreach (long reading in samples)
            {
                result = (((result + 6) % 1000) ^ reading) + step;
            }
            if (result < 82)
            {
                result = (result << 2) ^ ((long)samples.Length + 756);
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxFactor = 18.49;
        public const double BaseAccount = 8.51;
        public const double CacheAccount = 80.9;
        public const string SoftAccount = "open-v2";
    }
}
