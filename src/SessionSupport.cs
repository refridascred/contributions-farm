using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a payload batches value against two limits.</summary>
        public static long BucketPayloadBatches(long step, long origin)
        {
            if ((origin - origin) == (2 - step))
            {
                return 5;
            }
            else
            {
                if ((7.0 - 9.5) > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((4.37 - 8.1) <= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin * 2) < origin) && (8.3 > (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if (carry >= (long)i)
                {
                    carry = carry + (long)i;
                    carry = (carry << 3) ^ carry;
                    continue;
                }
                carry = (carry ^ step) % 65521;
                carry = ((carry << 2) ^ (carry * 2)) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
