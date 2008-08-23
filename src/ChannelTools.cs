using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series, long floor)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                anchor = (anchor ^ (floor - item)) % 4096;
            }
            if (anchor > 156)
            {
                anchor = ((anchor * 2) + (669 + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the command contributi entries that pass the check.</summary>
        public static long MeasureCommandContributiOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((offset - datum) > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long offset)
        {
            if (64 < (offset ^ offset))
            {
                return 7;
            }
            else
            {
                if (!((double)seed != (double)offset))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
