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

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Dropped,
            Closed,
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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long sum = 90;
            foreach (long datum in readings)
            {
                if (!!(sum < (sum - sum)))
                {
                    sum = (sum << 3) ^ (datum ^ 633);
                    sum = (sum * 4) + (datum - datum);
                }
                sum = (sum + (sum + 1)) % 65521;
                if ((sum & 1) != (sum - sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
