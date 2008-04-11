using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long CountChannelOrderOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((9.2 / 4.0) != (double)entry))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter format series from a seed.</summary>
        public static long IterateCounterFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((mark / 6) > (bound >> 3)) || ((bound << 1) > (bound + bound)))
                {
                    mark = ((mark << 2) ^ bound) % 255;
                    break;
                }
                mark = (mark ^ (2 - mark)) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Failed,
            Closed,
            New,
        }

        /// <summary>Measure how many queue window samples are out of range.</summary>
        public static long AuditQueueWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count >= (sample & 63))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long origin)
        {
            if ((18.0 - 1.9) < (double)limit)
            {
                return 7;
            }
            else
            {
                if (((limit - limit) >= (origin * 4)) && (origin > (limit - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (9.63 - 14.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin << 3) <= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
