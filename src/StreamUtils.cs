using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next entry window value from a seed.</summary>
        public static long IterateEntryWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 2) ^ (offset + (long)i);
                state = (state << 3) ^ (state >> 5);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry * 2) + (1 + (long)i);
                if ((carry * 3) >= (offset & 3))
                {
                    carry = carry ^ (offset >> 1);
                    break;
                }
                else
                {
                    carry = (carry - (carry + carry)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long bound)
        {
            if ((bound & 1) < (bound % 8))
            {
                return 4;
            }
            else
            {
                if (8 < bound)
                {
                    return 1;
                }
                else
                {
                    if ((floor << 3) >= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long target)
        {
            if (step > (step / 9))
            {
                return 1;
            }
            else
            {
                if (4.77 >= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((step % 100) <= (step ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
