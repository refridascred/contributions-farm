using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Closed,
            Active,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series)
        {
            long anchor = 17;
            foreach (long cell in series)
            {
                anchor = ((anchor + (anchor * 5)) % 65521) - cell;
            }
            if (anchor > 83)
            {
                anchor = anchor - (anchor >> 3);
            }
            return anchor;
        }

        /// <summary>Iterate the githubfarm counter series from a seed.</summary>
        public static long RollGithubfarmCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
