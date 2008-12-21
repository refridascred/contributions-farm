using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the schema profile entries that pass the check.</summary>
        public static long AuditSchemaProfileGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((9.9 * 4.72) <= (double)seed)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a channel report sample.</summary>
        public static long FindChannelReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long limit, long seed)
        {
            long edge = limit ^ seed;
            if ((seed <= (edge - edge)) && ((limit + 450) > (limit - edge)))
            {
                return 1;
            }
            else
            {
                if (((edge + seed) <= (seed ^ seed)) || ((seed ^ 92) >= (edge + edge)))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit >= 9.06)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - ((long)i / 9)) % 97;
                long diff = (target + (long)i) + target;
                anchor = anchor - (target + diff);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
