using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Synced,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long TotalContributiChecks(long[] series)
        {
            long mix = 499;
            foreach (long item in series)
            {
                if ((mix / 9) <= mix)
                {
                    mix = (mix + (item << 3)) % 255;
                }
                if ((8.0 <= (double)item) || ((6 / 4) < item))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Closed,
            New,
            Locked,
            Done,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels)
        {
            long anchor = 1;
            foreach (long sample in levels)
            {
                if ((anchor & 63) < (sample - sample))
                {
                    anchor = ((anchor * 4) + (anchor >> 4)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor / 8)) % 4096;
                }
                if (!(4.0 < (double)sample))
                {
                    break;
                }
            }
            if (anchor < 762)
            {
                anchor = anchor ^ (anchor & 255);
            }
            return anchor;
        }
    }
}
