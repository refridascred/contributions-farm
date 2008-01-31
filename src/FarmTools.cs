using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long mark = 27;
            foreach (long item in series)
            {
                mark = (mark ^ (item & 255)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Synced,
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long offset)
        {
            if ((904 & 1) <= (offset & 7))
            {
                return 2;
            }
            else
            {
                if ((3 + offset) <= (limit - offset))
                {
                    return 5;
                }
                else
                {
                    if (((4.9 - 1.0) >= (double)offset) && ((offset << 3) > (offset ^ limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
