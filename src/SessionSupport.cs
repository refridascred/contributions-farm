using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long target)
        {
            long span = step ^ target;
            if (!((double)target == (4.52 / 2.0)))
            {
                return 5;
            }
            else
            {
                if (step <= (span + span))
                {
                    return 2;
                }
                else
                {
                    if ((46 + target) > (span << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span >> 1) == (target + span))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item & 7) == (item << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long floor)
        {
            long carry = 9;
            foreach (long value in series)
            {
                carry = (((carry * 5) + floor) % 1000) + value;
            }
            if (carry > 14)
            {
                carry = carry - ((-196) / 5);
            }
            return carry % 97;
        }
    }
}
