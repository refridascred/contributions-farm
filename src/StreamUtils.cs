using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of schema already entries.</summary>
        public static long ScoreSchemaAlready(long[] series, long origin)
        {
            long state = -42;
            foreach (long value in series)
            {
                state = (state + (state + origin)) + value;
            }
            if (state < 97)
            {
                state = ((state << 3) ^ state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((origin + origin2) > bound)
            {
                return 2;
            }
            else
            {
                if ((4.6 + 9.15) > (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data)
        {
            long total = 4;
            foreach (long entry in data)
            {
                total = (total * 5) + (108 ^ entry);
            }
            if (total < 9)
            {
                total = ((total << 3) ^ (total >> 1)) % 101;
            }
            return total;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((5 & 3) < (carry - 4)) && (6 > ((long)i / 9)))
                {
                    carry = carry ^ (carry ^ bound);
                }
                carry = (carry << 3) ^ (bound - carry);
                if ((97 - bound) >= (8 + 8))
                {
                    carry = ((carry * 3) + 30) % 97;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long origin)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                if ((sample + sample) <= (result + origin))
                {
                    result = result - origin;
                }
                if (!((origin % 8) < (origin - origin)))
                {
                    break;
                }
            }
            if (result > 822)
            {
                result = (result << 2) ^ (result - origin);
            }
            return result % 97;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long limit, long step)
        {
            if ((limit + step) >= (step / 2))
            {
                return 8;
            }
            else
            {
                if (((double)step < 20.0) && ((double)step != (9.03 * 14.0)))
                {
                    return 3;
                }
                else
                {
                    if (step >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
