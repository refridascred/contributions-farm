using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor ^ (target >> 5);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            New,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 7) >= (bound % 5))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
