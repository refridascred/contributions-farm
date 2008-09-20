using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long offset, long step)
        {
            if ((offset ^ offset) <= (offset + offset))
            {
                return 1;
            }
            else
            {
                if (7.27 < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (!((offset << 2) >= 71))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Failed,
            New,
            Retry,
            Stale,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double load = (double)56 + (double)2;
            if (load <= (offset - load))
            {
                load = load - load;
            }
            return load + scale;
        }
    }
}
