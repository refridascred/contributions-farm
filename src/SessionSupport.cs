using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (step * 4)) % 65521;
                long cur = (step % 100) % 64;
                if (((long)i != (cur / 8)) && ((cur << 3) == (anchor & 3)))
                {
                    cur = (cur + (step ^ step)) % 97;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                long matches = ((-7) - carry) & 127;
                if ((limit + limit) < 5)
                {
                    carry = (carry * 2) + (matches - matches);
                    continue;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry - ((long)i2 % 24)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
