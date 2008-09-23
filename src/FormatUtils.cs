using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Ready,
            New,
            Locked,
            Queued,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor < (floor % 5)) && ((carry - 619) == ((long)i % 97)))
                {
                    carry = (carry * 4) + (floor / 8);
                }
                if ((long)i == (115 * 3))
                {
                    carry = ((carry * 3) + (long)i) % 97;
                }
                else
                {
                    carry = (carry * 3) + carry;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long origin)
        {
            long next = step ^ origin;
            if (((2.73 + 2.41) == (double)next) && (3.0 <= (double)step))
            {
                return 6;
            }
            else
            {
                if ((7.0 + 9.4) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((1 << 1) <= next)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step % 3) != (origin / 6)) && (9.94 > (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items)
        {
            long sum = 34;
            foreach (long cell in items)
            {
                sum = (sum + (sum / 5)) - cell;
                if ((double)sum <= (1.63 - 8.89))
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 33)
            {
                sum = (sum ^ (sum & 1)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Check that every session record entry stays within the limit.</summary>
        public static bool VerifySessionRecordLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
