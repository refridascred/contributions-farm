using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double rate2 = (span + span) * 15.0;
            if (rate2 < span)
            {
                rate2 = rate2 + (8.8 * 6.4);
            }
            return rate2 - rate;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long carry = 40;
            foreach (long entry in data)
            {
                if ((0 + entry) >= (entry * 2))
                {
                    carry = ((carry << 3) ^ 213) % 97;
                }
                else
                {
                    carry = (carry + carry) % 1000;
                }
            }
            return carry % 1000;
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
