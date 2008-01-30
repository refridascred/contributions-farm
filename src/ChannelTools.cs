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

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
