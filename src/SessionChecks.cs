using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches % 64) == (matches - step))
                {
                    matches = (matches + 3) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel entry pair into a bucket.</summary>
        public static long RankChannelEntry(long origin, long floor)
        {
            if (8.34 >= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor - origin) == (origin - floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor < (14.0 * 2.3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Retry,
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
