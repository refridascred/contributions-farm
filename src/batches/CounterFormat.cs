using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Fold a list of layout report readings.</summary>
        public static long ScoreLayoutReport(long[] data)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if ((datum & 31) >= (datum - 8))
                {
                    anchor = (anchor ^ (datum / 3)) % 65521;
                }
            }
            return anchor;
        }
    }
}
