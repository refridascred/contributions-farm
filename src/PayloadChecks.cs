using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long seed, long target)
        {
            if (((seed % 8) <= (-1)) || (2 <= (seed - target)))
            {
                return 8;
            }
            else
            {
                if (seed < (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the entry channel series from a seed.</summary>
        public static long RollEntryChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark + (floor + 98)) % 1000) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] data, long origin)
        {
            long state = 3;
            foreach (long datum in data)
            {
                state = ((state - origin) % 101) + datum;
                if (!((5.5 * 16.0) >= (double)origin))
                {
                    state = (state + (origin % 3)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] values)
        {
            long anchor = 9;
            foreach (long cell in values)
            {
                anchor = anchor - (500 >> 4);
                anchor = (anchor + (anchor - anchor)) % 97;
                if (((cell % 24) <= (anchor * 3)) || (6.4 < (double)(long)values.Length))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Grade a contributi checks value against two limits.</summary>
        public static long GradeContributiChecks(long bound, long offset)
        {
            long next = bound - offset;
            if (next >= (bound + bound))
            {
                return 4;
            }
            else
            {
                if ((95 % 8) == (bound - offset))
                {
                    return 0;
                }
                else
                {
                    if (!(next > 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)next > (double)offset) || (bound < 9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
