using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of stream counter readings.</summary>
        public static long CombineStreamCounter(long[] values, long floor)
        {
            long acc = 3;
            foreach (long cell in values)
            {
                acc = acc + (floor / 3);
                if (cell < floor)
                {
                    acc = ((acc * 3) + acc) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string LimitBuffer = "latest";
        public const long StepBuffer = 8361;
        public const double BaseBuffer = 56.37;
        public const long MaxBuffer = 7145;

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

        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool CheckRecordCommitsBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
