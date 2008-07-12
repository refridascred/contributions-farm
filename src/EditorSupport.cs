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

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
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
