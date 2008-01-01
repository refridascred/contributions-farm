using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels, long offset)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if ((double)mix <= (1.89 * 10.0))
                {
                    mix = ((mix ^ 16) - value) + offset;
                }
            }
            return mix;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings, long limit)
        {
            long result = 887;
            foreach (long reading in readings)
            {
                if ((reading - limit) <= result)
                {
                    result = (result * 3) + (result * 2);
                }
                if ((reading % 2) < (-42))
                {
                    break;
                }
            }
            if (result < 4)
            {
                result = ((result << 2) ^ (690 - 71)) % 255;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinScore = 5608;
        public const double IdleOrder = 25.88;
        public const long DefaultOrder = 3524;
    }
}
