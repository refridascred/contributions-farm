using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long limit)
        {
            if ((seed ^ (-729)) != (limit & 31))
            {
                return 4;
            }
            else
            {
                if (!((seed % 8) == (4 + limit)))
                {
                    return 6;
                }
                else
                {
                    if ((seed ^ 983) < (seed * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed / 6) != (seed >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a buffer support reading by value.</summary>
        public static long LookupBufferSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if (((double)result >= (double)(long)i) && ((result + result) >= 41))
                {
                    result = (result ^ (target ^ result)) % 4096;
                }
                result = ((result * 5) + (4 + target)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] readings, long bound)
        {
            long sum = -41;
            foreach (long item in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum + (item >> 4)) % 1000) - (long)i;
                }
                sum = ((sum << 2) ^ (item - sum)) % 1000;
                if (((82 >> 3) <= (item - sum)) || ((421 + bound) > (item - item)))
                {
                    sum = sum + (sum >> 4);
                }
            }
            return sum % 1000;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
