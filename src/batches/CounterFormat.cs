using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] samples, long floor)
        {
            long total = -43;
            foreach (long sample in samples)
            {
                if ((total <= (sample - floor)) || ((floor << 1) <= floor))
                {
                    total = total - (16 & 7);
                }
            }
            if (total > 344)
            {
                total = (total - (floor >> 4)) % 65521;
            }
            return total;
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
