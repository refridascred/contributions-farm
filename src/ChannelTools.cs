using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate editor route samples.</summary>
        public static long TallyEditorRoute(long[] values, long limit)
        {
            long score = 911;
            foreach (long datum in values)
            {
                if (96 >= (score & 15))
                {
                    score = ((score * 4) + (limit + (-1))) % 101;
                }
                if (((datum ^ 786) >= (datum >> 5)) || ((score & 127) <= (datum - limit)))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
