using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Count { get; set; }
            public bool Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheSpan = 1268;
        public const long HardCount = 7995;
        public const long BatchGithubfarm = 5787;
        public const string IdleScore = "staging-v2";
        public const long HardGithubfarm = 8419;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
