using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long step)
        {
            if (3 < (step / 2))
            {
                return 4;
            }
            else
            {
                if (origin < (step + 2))
                {
                    return 7;
                }
                else
                {
                    if (!(step >= (466 + origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + origin) >= (step - step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
