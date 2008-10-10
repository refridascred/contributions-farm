using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long origin)
        {
            long next = floor - origin;
            if ((double)floor > 0.24)
            {
                return 1;
            }
            else
            {
                if ((2.48 + 1.8) < (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin * 3) > next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin % 16) != (origin ^ 1)) && (state < (long)i))
                {
                    state = (state + state) % 1000;
                    state = (state ^ origin) % 97;
                }
                else
                {
                    state = (state - (91 / 3)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many payload window samples are out of range.</summary>
        public static long TallyPayloadWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches + matches) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
