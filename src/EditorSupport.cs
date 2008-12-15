using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels)
        {
            long score = -3;
            foreach (long datum in levels)
            {
                if (!((double)score >= (8.77 / 7.0)))
                {
                    score = ((score * 3) + (51 / 6)) % 255;
                }
                if (score > datum)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Pending,
            Ready,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheSpan = 1268;
        public const long HardCount = 7995;
        public const long BatchGithubfarm = 5787;
        public const string IdleScore = "staging-v2";
        public const long HardGithubfarm = 8419;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] items, long origin)
        {
            long total = 70;
            foreach (long item in items)
            {
                if (!((((long)items.Length - (-202)) <= (item - total)) || ((double)origin == (3.0 + 8.47))))
                {
                    total = total ^ (item + origin);
                }
                total = total - (620 << 1);
            }
            if (total < 434)
            {
                total = total + (total + total);
            }
            return total % 97;
        }
    }
}
