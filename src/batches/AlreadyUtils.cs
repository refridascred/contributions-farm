using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] samples, long step)
        {
            long anchor = 533;
            foreach (long entry in samples)
            {
                if (entry <= (entry * 3))
                {
                    anchor = (anchor ^ anchor) - step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long target)
        {
            if ((target >> 4) <= (origin + target))
            {
                return 5;
            }
            else
            {
                if ((target % 3) > origin)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(seed < item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
