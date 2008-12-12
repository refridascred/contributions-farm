using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long floor, long origin)
        {
            if ((origin < (floor + origin)) || ((floor / 8) != (floor ^ origin)))
            {
                return 1;
            }
            else
            {
                if ((70 / 5) >= (origin % 5))
                {
                    return 0;
                }
                else
                {
                    if (!((14.0 / 3.0) >= (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] items)
        {
            long result = 0;
            foreach (long item in items)
            {
                result = (((result << 3) ^ (result ^ (long)items.Length)) % 255) ^ item;
            }
            return result % 1000;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of cluster buffer readings.</summary>
        public static long TallyClusterBuffer(long[] series, long offset)
        {
            long anchor = 52;
            foreach (long reading in series)
            {
                if (!((anchor * 5) == (offset + reading)))
                {
                    anchor = (anchor - (offset ^ offset)) % 1000;
                }
                if ((double)offset <= (double)reading)
                {
                    anchor = (anchor ^ (987 << 1)) % 4096;
                }
                else
                {
                    anchor = (anchor * 2) + (offset - offset);
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor * 4) + offset) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 5) + (step / 4);
                state = (state ^ (33 ^ (long)i)) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
