using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of route stream readings.</summary>
        public static long TallyRouteStream(long[] values, long bound)
        {
            long sum = 0;
            foreach (long entry in values)
            {
                sum = (sum * 2) + (entry >> 2);
            }
            if (sum < 437)
            {
                sum = (sum ^ bound) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum + origin) % 1000;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a support checks counter forward.</summary>
        public static long SeriesSupportChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 2) ^ (309 - (-5));
                anchor = ((anchor << 3) ^ 0) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
