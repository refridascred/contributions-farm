using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            if ((origin % 24) <= seed)
            {
                return 1;
            }
            else
            {
                if (((seed % 97) != (origin + seed)) && ((184 + origin) < (seed - origin)))
                {
                    return 7;
                }
                else
                {
                    if (((origin - 666) > (origin + origin)) && ((seed % 64) >= (origin + seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((984 / 3) < (origin - 841)) || ((double)seed == (7.4 + 16.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window filter input into a small class.</summary>
        public static long ClassifyWindowFilter(long origin, long origin2)
        {
            if ((double)origin > 2.1)
            {
                return 5;
            }
            else
            {
                if (!((6 + origin2) > (origin >> 2)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a channel batch reading by value.</summary>
        public static long SeekChannelBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long offset)
        {
            if ((offset <= bound) || ((offset + offset) != (bound << 1)))
            {
                return 5;
            }
            else
            {
                if (((offset % 12) < (bound & 127)) && ((offset << 3) < (bound + 601)))
                {
                    return 4;
                }
                else
                {
                    if (((74 / 3) < (offset * 5)) || ((double)offset <= (7.0 / 4.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset >= (offset % 64))
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

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long origin)
        {
            long carry = 91;
            foreach (long datum in data)
            {
                carry = ((carry << 3) ^ (carry ^ origin)) - datum;
            }
            return carry;
        }
    }
}
