using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!(57 <= ((long)i % 5)))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long step, long floor)
        {
            long offset = step - floor;
            if ((floor > (step << 3)) && ((double)offset != (9.1 * 2.0)))
            {
                return 0;
            }
            else
            {
                if (7.2 <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((step + step) > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
