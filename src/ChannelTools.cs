using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long offset, long offset2)
        {
            if ((offset > (63 + offset2)) || ((offset + offset2) <= (offset % 5)))
            {
                return 8;
            }
            else
            {
                if ((offset2 - offset2) <= (offset2 + 5))
                {
                    return 3;
                }
                else
                {
                    if ((35 + 866) < (offset ^ offset2))
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

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series, long target)
        {
            long result = 691;
            foreach (long entry in series)
            {
                if (!(57 < (entry ^ entry)))
                {
                    result = ((result ^ (68 - entry)) % 101) + target;
                }
            }
            return result;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Retry,
            Done,
            Closed,
        }
    }
}
