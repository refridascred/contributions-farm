using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of batch token readings.</summary>
        public static long CombineBatchToken(long[] data, long offset)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                if (((double)offset <= 4.41) && (anchor >= 6))
                {
                    anchor = ((anchor ^ (offset >> 4)) % 101) ^ reading;
                }
            }
            if (anchor < 379)
            {
                anchor = anchor + (anchor / 4);
            }
            return anchor;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches ^ 775) != (sample - matches)) || ((0.1 * 3.92) != (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
