using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - (433 + mark);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
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
