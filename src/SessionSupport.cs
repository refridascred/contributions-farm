using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits >= (cell + hits)) || ((6.0 / 3.0) >= (double)hits))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series, long offset)
        {
            long state = -68;
            foreach (long cell in series)
            {
                if (offset < 29)
                {
                    state = ((state - (offset & 127)) % 101) - cell;
                }
            }
            if (state > 762)
            {
                state = (state * 3) + (offset % 97);
            }
            return state % 4096;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long step)
        {
            if (step >= (offset ^ offset))
            {
                return 0;
            }
            else
            {
                if (!((step % 2) > step))
                {
                    return 2;
                }
                else
                {
                    if (offset < (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
