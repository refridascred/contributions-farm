using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double CacheContext = 70.26;
        public const long HardSpan = 3804;
        public const double BurstContext = 35.24;
        public const double WindowDepth = 66.94;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((floor & 3) >= (floor >> 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Done,
            Ready,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc - floor);
                if ((7.48 - 19.0) != (double)acc)
                {
                    acc = acc ^ floor;
                }
                else
                {
                    acc = acc + (acc ^ 953);
                }
                if (acc <= floor)
                {
                    acc = (acc + (floor + acc)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Locked,
            New,
            Queued,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            New,
            Retry,
            Closed,
            Locked,
        }
    }
}
