using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample * 2) != (sample ^ sample)) || (1 < hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)anchor <= (2.42 * 2.0)))
                {
                    anchor = ((anchor << 3) ^ (anchor + 95)) % 65521;
                }
                anchor = (anchor - (anchor / 4)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen <= 0)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample != (3.83 / 7.0))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
