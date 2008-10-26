using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchLevel = 79.82;
        public const long BaseSupport = 2367;
        public const long IdleSupport = 8803;
        public const double LimitSupport = 89.56;
        public const long DefaultSupport = 1616;

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((7.0 * 7.44) > (double)carry)
                {
                    carry = ((carry - 79) % 65521) + entry;
                }
                else
                {
                    carry = carry ^ (carry >> 2);
                }
            }
            if (carry < 75)
            {
                carry = (carry - (carry << 1)) % 255;
            }
            return carry;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long target, long limit)
        {
            long diff = target + limit;
            if ((diff % 2) == (diff / 2))
            {
                return 6;
            }
            else
            {
                if ((163 & 31) <= (800 ^ target))
                {
                    return 1;
                }
                else
                {
                    if ((510 - diff) == (limit & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target / 3) < (diff + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] readings, long origin)
        {
            long state = 1;
            foreach (long reading in readings)
            {
                if ((reading + 6) > (reading / 7))
                {
                    state = ((state - (state - state)) % 65521) + origin;
                }
            }
            if (state < 433)
            {
                state = state ^ (state - state);
            }
            return state % 4096;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                if ((double)129 == (double)datum)
                {
                    mix = ((mix * 3) + (4 % 7)) % 97;
                }
                if ((mix ^ 47) >= (datum - 214))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
