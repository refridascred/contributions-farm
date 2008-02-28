using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a layout support value against two limits.</summary>
        public static long GradeLayoutSupport(long origin, long step)
        {
            if (!(origin > (step * 2)))
            {
                return 0;
            }
            else
            {
                if ((double)origin <= 11.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (7.0 - 5.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a already commits sample.</summary>
        public static long SeekAlreadyCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
