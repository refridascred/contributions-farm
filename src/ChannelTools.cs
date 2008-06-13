using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long seed)
        {
            long step = bound - seed;
            if (!(seed > step))
            {
                return 5;
            }
            else
            {
                if (3.5 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (seed >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((bound + bound) >= (bound & 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
