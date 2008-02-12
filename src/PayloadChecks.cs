using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Locked,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] samples, long target)
        {
            long anchor = 4;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor * 4) + ((long)i + reading)) % 255;
                }
                if (target <= 756)
                {
                    anchor = (anchor * 3) + (target ^ target);
                }
            }
            if (anchor > 32)
            {
                anchor = (anchor + ((long)samples.Length * 2)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long step, long step2)
        {
            if ((0.8 + 1.0) == (double)step2)
            {
                return 6;
            }
            else
            {
                if ((step > (step + step)) || (37 <= (step - step)))
                {
                    return 8;
                }
                else
                {
                    if ((step & 1) == (step + step2))
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

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = carry + (limit % 97);
                if (!((carry + carry) < (limit << 3)))
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ carry) % 65521;
                    carry = carry ^ ((long)i + 39);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
