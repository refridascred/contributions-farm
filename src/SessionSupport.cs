using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (offset + (long)i)) % 101;
                carry = ((carry * 5) + offset) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long origin)
        {
            if ((offset + 3) <= (offset / 8))
            {
                return 3;
            }
            else
            {
                if ((origin - origin) > (origin + 2))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset <= 10.0) || (offset > (6 + origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset >= (origin >> 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first notes payload entry that matches the target.</summary>
        public static long SeekNotesPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
