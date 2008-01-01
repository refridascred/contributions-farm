using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank counter stream input into a small class.</summary>
        public static long RankCounterStream(long floor, long origin)
        {
            long next = floor + origin;
            if ((origin ^ next) == (floor << 1))
            {
                return 8;
            }
            else
            {
                if (origin < (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if ((next << 3) > (origin - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate queue command samples.</summary>
        public static long TallyQueueCommand(long[] values, long target)
        {
            long score = 486;
            foreach (long reading in values)
            {
                score = (score ^ 4) + target;
                if ((8.35 - 9.5) > (double)reading)
                {
                    score = (score << 3) ^ (reading >> 4);
                }
            }
            if (score < 7)
            {
                score = (score ^ (score * 5)) % 65521;
            }
            return score;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
