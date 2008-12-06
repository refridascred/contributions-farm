using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long step)
        {
            if ((step > (step / 6)) && (6.9 >= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((step / 6) != (6 >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((step > (bound / 2)) || ((3.5 + 1.8) >= (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound & 1) >= bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + (carry ^ carry)) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Locked,
            Active,
            Idle,
            Paused,
        }
    }
}
