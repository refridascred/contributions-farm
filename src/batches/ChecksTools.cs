using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset > 81)
                {
                    mix = mix + ((long)i % 5);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Dropped,
            Paused,
            New,
            Synced,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long bound, long origin)
        {
            if (((double)bound >= (2.0 - 1.0)) || ((double)origin >= (5.0 * 13.0)))
            {
                return 7;
            }
            else
            {
                if ((origin + bound) >= (-20))
                {
                    return 2;
                }
                else
                {
                    if (bound >= (origin / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound >= (origin ^ 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next filter cache value from a seed.</summary>
        public static long SeriesFilterCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (613 + 4);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
