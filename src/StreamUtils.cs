using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            New,
            Stale,
            Pending,
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long CombineSessionCluster(long[] series, long origin)
        {
            long mix = -102;
            foreach (long reading in series)
            {
                if (((3.12 + 2.7) < (double)mix) || ((origin / 8) > reading))
                {
                    mix = (mix * 4) + (reading << 3);
                }
            }
            return mix;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry ^ (carry & 7)) % 4096) - (long)i2;
                    carry = ((carry * 2) + (offset * 5)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long bound)
        {
            long offset = floor - bound;
            if ((double)offset != (1.5 + 11.0))
            {
                return 0;
            }
            else
            {
                if ((4.4 + 3.44) < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((19.0 - 9.7) > (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (89 > floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a command context counter forward.</summary>
        public static long DeriveCommandContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor - (99 - anchor)) % 65521;
                anchor = anchor - 2;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
