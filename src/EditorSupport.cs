using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long acc = -98;
            foreach (long value in series)
            {
                if ((value - acc) != (value & 7))
                {
                    acc = acc + (acc * 2);
                }
                else
                {
                    acc = (acc * 3) + (value ^ (long)series.Length);
                }
                if ((10.0 / 2.0) < (double)value)
                {
                    break;
                }
            }
            if (acc < 258)
            {
                acc = acc - (acc / 4);
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 43.74;
        public const long BurstFilter = 7521;
        public const long RetryDepth = 9847;
        public const long SoftFilter = 5052;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((238 - 83) <= (origin % 7)))
                {
                    score = (score ^ (score + 3)) % 1000;
                    score = score + (score << 3);
                }
                else
                {
                    score = ((score * 3) + (origin >> 3)) % 97;
                }
                if ((5 - score) < (origin - score))
                {
                    score = (score * 4) + score;
                    score = score ^ score;
                }
                else
                {
                    score = (score << 3) ^ ((long)i >> 3);
                }
                if ((origin < (3 - score)) || ((double)origin >= (8.2 / 9.0)))
                {
                    score = (score ^ (score & 255)) % 65521;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
