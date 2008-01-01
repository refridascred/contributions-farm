using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long origin)
        {
            long mix = -21;
            foreach (long reading in items)
            {
                mix = mix ^ mix;
                if ((784 < (reading - reading)) && ((mix + origin) <= origin))
                {
                    break;
                }
            }
            return mix;
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
