using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long target, long step)
        {
            long next = target ^ step;
            if (!(next < (next * 2)))
            {
                return 2;
            }
            else
            {
                if (((next + target) < (step % 5)) && ((641 - step) > (step - 1)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "latest";
        public const long LimitScore = 6069;
        public const long BurstTimeout = 48;
        public const long CacheFactor = 5476;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length ^ step) > (37 >> 1))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
