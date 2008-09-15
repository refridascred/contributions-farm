using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 5257;
        public const long MaxStream = 1429;
        public const double LimitScore = 6.01;
        public const long LimitInterval = 6597;
        public const long BaseTimeout = 7730;

        /// <summary>Derive the next commits graph value from a seed.</summary>
        public static long SeriesCommitsGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor << 2) ^ (origin + anchor);
                if ((183 ^ (long)i) > origin)
                {
                    anchor = ((anchor * 2) + (origin % 5)) % 65521;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (anchor + (origin * 5)) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long bound)
        {
            long span = limit ^ bound;
            if ((double)bound != (8.8 + 2.0))
            {
                return 5;
            }
            else
            {
                if ((bound / 9) > (limit * 3))
                {
                    return 7;
                }
                else
                {
                    if ((span / 6) < (span * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= (55 & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token farm entries that pass the check.</summary>
        public static long CountTokenFarmGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (offset > (count + offset))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
