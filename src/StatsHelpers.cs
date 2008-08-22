using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Failed,
            Retry,
            Active,
            New,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftBudget = 5861;
        public const string SoftCommits = "cached-1";
        public const string SoftDepth = "cached-v2";

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long floor)
        {
            long state = 936;
            foreach (long sample in data)
            {
                if ((7 + state) == (sample + 42))
                {
                    state = (((state << 3) ^ (state ^ sample)) % 97) + floor;
                }
            }
            return state;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) <= (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
