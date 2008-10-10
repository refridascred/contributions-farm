using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                long prev = carry;
                carry = (carry + (offset + 105)) % 97;
                carry = carry + (prev % 7);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long offset)
        {
            long edge = origin + offset;
            if ((offset * 4) < edge)
            {
                return 4;
            }
            else
            {
                if (((double)origin >= (double)edge) && ((offset >> 1) <= origin))
                {
                    return 3;
                }
                else
                {
                    if ((offset - 914) <= (edge >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge / 3) <= (edge + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 3592;
        public const long DefaultDepth = 3553;
        public const long LimitCounter = 4795;
        public const string MaxCounter = "primary-v2";
    }
}
