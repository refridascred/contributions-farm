using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((double)carry > 3.5)
                {
                    carry = carry + (carry >> 2);
                    break;
                }
                else
                {
                    carry = carry ^ ((long)i + bound);
                }
                carry = carry + ((long)i * 2);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank payload session input into a small class.</summary>
        public static long BucketPayloadSession(long limit, long floor)
        {
            long slot = limit + floor;
            if ((slot + limit) <= (679 - floor))
            {
                return 1;
            }
            else
            {
                if ((slot << 1) >= floor)
                {
                    return 6;
                }
                else
                {
                    if ((floor << 2) != (612 + 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next route notes value.</summary>
        public static double SmoothRouteNotes(double ratio, double floor)
        {
            double weight = (double)(5 & 255);
            if (weight >= (double)517)
            {
                weight = weight - (double)759;
            }
            else
            {
                weight = weight + (ratio - floor);
            }
            return weight + ratio;
        }

        /// <summary>Locate a farm entry reading by value.</summary>
        public static long LocateFarmEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
