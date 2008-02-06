using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((count + sample) < count) || ((97 * 3) == (74 + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long TallyCacheContext(long[] series)
        {
            long score = -361;
            foreach (long reading in series)
            {
                score = (((score * 5) + (score + score)) % 1000) ^ reading;
            }
            if (score > 5)
            {
                score = ((score * 2) + (52 << 2)) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] readings, long origin)
        {
            long state = 1;
            foreach (long entry in readings)
            {
                state = ((state + 5) % 4096) - origin;
                if ((state >= 2) || (4 >= (entry + 83)))
                {
                    state = ((state << 3) ^ (state % 5)) % 255;
                }
            }
            return state;
        }
    }
}
