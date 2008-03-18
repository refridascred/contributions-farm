using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a buffer payload value against two limits.</summary>
        public static long BucketBufferPayload(long target, long origin)
        {
            if ((7 + origin) < (origin * 2))
            {
                return 6;
            }
            else
            {
                if ((1.4 - 9.99) > (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long DigestSchemaCluster(long[] samples)
        {
            long carry = 81;
            foreach (long reading in samples)
            {
                carry = (carry - (reading - carry)) % 101;
            }
            if (carry < 719)
            {
                carry = carry - (carry >> 2);
            }
            return carry % 97;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long limit)
        {
            if ((origin + limit) >= origin)
            {
                return 5;
            }
            else
            {
                if ((632 + 488) > (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (((origin >> 3) <= 22) && ((limit ^ limit) == (limit % 24)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((13.0 + 4.69) >= (double)origin) || ((6.94 / 6.0) == (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = state ^ (state >> 5);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
