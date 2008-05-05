using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a window route counter forward.</summary>
        public static long RollWindowRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long origin, long origin2)
        {
            if ((8 - 70) > (2 + origin2))
            {
                return 0;
            }
            else
            {
                if (origin < (origin2 - origin))
                {
                    return 2;
                }
                else
                {
                    if (((origin * 3) != (origin - origin2)) && ((double)origin2 < (1.7 * 8.8)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin - origin) <= origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data)
        {
            long mark = 775;
            foreach (long sample in data)
            {
                if ((mark / 5) != (sample + mark))
                {
                    mark = ((mark << 3) ^ (mark + sample)) % 4096;
                }
            }
            if (mark > (-97))
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long origin)
        {
            if ((bound * 5) > bound)
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) > (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin % 97) > 88)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - bound) > (bound + 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
