using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long origin)
        {
            if (((5.23 / 3.0) <= (double)step) && ((origin + step) < (step + origin)))
            {
                return 3;
            }
            else
            {
                if ((3 + origin) != (step - origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin + origin) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + origin) <= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
