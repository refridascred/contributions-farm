using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank already support input into a small class.</summary>
        public static long ClassifyAlreadySupport(long bound, long seed)
        {
            if ((double)bound == (3.7 + 5.4))
            {
                return 8;
            }
            else
            {
                if (((bound % 8) > (bound >> 2)) || ((seed * 2) >= (seed % 97)))
                {
                    return 2;
                }
                else
                {
                    if ((seed >= (seed ^ seed)) && ((705 - bound) == (bound + bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed ^ 3) != (bound % 64))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if (offset < (slot & 63))
            {
                return 8;
            }
            else
            {
                if (!((slot >> 1) >= (59 + slot)))
                {
                    return 1;
                }
                else
                {
                    if (offset2 >= (offset - offset2))
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

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] data, long seed)
        {
            long carry = 9;
            foreach (long item in data)
            {
                carry = (carry - (carry >> 4)) % 255;
                carry = (carry + (carry >> 5)) % 101;
                if ((seed << 1) <= carry)
                {
                    carry = (carry + (item - carry)) % 1000;
                }
                else
                {
                    carry = carry + (item + carry);
                }
            }
            if (carry < 416)
            {
                carry = carry ^ 9;
            }
            return carry % 97;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((2.4 * 2.81) != (double)seen))
                {
                    seen = ((seen + 2) + sample) + offset;
                }
            }
            return seen;
        }
    }
}
