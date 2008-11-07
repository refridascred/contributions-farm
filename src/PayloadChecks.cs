using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseDepth = 89.56;
        public const double CacheCounter = 71.65;
        public const string WindowCounter = "latest";
        public const long StepCounter = 777;

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long limit)
        {
            if ((495 & 255) != (limit ^ limit))
            {
                return 2;
            }
            else
            {
                if (((50 - (-766)) <= (limit % 64)) && ((offset % 97) < (limit + offset)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
