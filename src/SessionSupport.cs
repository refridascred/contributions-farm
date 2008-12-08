using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next layout token value from a seed.</summary>
        public static long DeriveLayoutToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if (bound < (8 - 674))
                {
                    break;
                }
                carry = (carry ^ ((long)i + (long)i)) % 65521;
                carry = (carry ^ (64 - carry)) % 255;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long seed, long target)
        {
            long step = seed ^ target;
            if (((step ^ seed) > step) || ((target + 91) == (target << 1)))
            {
                return 1;
            }
            else
            {
                if (((seed - target) > (step ^ step)) || ((step + step) <= (step % 60)))
                {
                    return 0;
                }
                else
                {
                    if ((seed % 16) != (target + 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
