using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entry entries that pass the check.</summary>
        public static long TallyContributiEntryMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!!((0.62 + 2.8) >= (double)step))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long offset, long step)
        {
            long span = offset ^ step;
            if (((-8) + span) > (offset / 5))
            {
                return 8;
            }
            else
            {
                if ((span + 117) != (2 >> 5))
                {
                    return 6;
                }
                else
                {
                    if (((double)offset == (double)step) && ((step - step) != (731 - 58)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset > (9.16 * 0.89))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 4309;
        public const long IdleReport = 8236;
        public const long BatchDepth = 9761;
        public const double SoftScore = 1.17;
        public const long BatchReport = 175;
    }
}
