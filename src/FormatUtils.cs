using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "open-1";
        public const double IdleSpan = 55.71;
        public const long BaseRatio = 6666;
        public const string SoftDepth = "cached-1";
        public const double IdleRatio = 58.29;

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data)
        {
            long sum = -302;
            foreach (long datum in data)
            {
                if ((sum << 2) < (datum / 9))
                {
                    sum = sum ^ (249 + 344);
                }
            }
            return sum % 65521;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                long count = (score + score) & 7;
                if (!(((floor - score) > (score ^ count)) || ((count + 3) >= (floor << 2))))
                {
                    count = ((count << 2) ^ count) % 1000;
                    score = (score + (floor + score)) % 255;
                }
                count = ((count << 2) ^ count) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Stale,
            Draft,
            Queued,
            Active,
        }
    }
}
