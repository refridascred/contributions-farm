using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 5325;
        public const long BatchScore = 7815;
        public const long CacheSpan = 5457;
        public const long WindowWidth = 9724;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Mode { get; set; }
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double span)
        {
            double drift = (double)452;
            if (drift <= gain)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Grade a schema window value against two limits.</summary>
        public static long RankSchemaWindow(long limit, long floor)
        {
            if (!((limit - floor) <= (floor >> 2)))
            {
                return 1;
            }
            else
            {
                if ((895 + (-556)) <= (limit - floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
