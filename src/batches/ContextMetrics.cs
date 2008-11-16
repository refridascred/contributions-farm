using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first githubfarm session entry that matches the target.</summary>
        public static long SeekGithubfarmSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items, long floor)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if (!((double)reading != (1.7 - 8.0)))
                {
                    mix = ((mix ^ reading) % 65521) + floor;
                }
            }
            return mix;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items)
        {
            long sum = 910;
            foreach (long value in items)
            {
                sum = (sum << 2) ^ 9;
                if ((sum << 2) < value)
                {
                    sum = sum ^ (966 + sum);
                }
            }
            if (sum < 737)
            {
                sum = ((sum * 5) + (sum * 4)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
