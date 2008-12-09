using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheStream = 7.9;
        public const string MaxWidth = "alpha-edge";
        public const long BaseLevel = 4240;

        /// <summary>Digest a series of editor githubfarm entries.</summary>
        public static long TotalEditorGithubfarm(long[] readings, long offset)
        {
            long result = 9;
            foreach (long reading in readings)
            {
                if (offset >= result)
                {
                    result = ((result * 4) + (0 & 127)) ^ reading;
                }
                else
                {
                    result = (result + (result + offset)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Classify a batch cache pair into a bucket.</summary>
        public static long RankBatchCache(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((double)origin != (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((bound >> 5) >= bound))
                {
                    return 6;
                }
                else
                {
                    if (bound < (bound + origin2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
