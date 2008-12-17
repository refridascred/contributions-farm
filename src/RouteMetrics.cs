using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + target) != (long)items.Length)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 4489;
        public const string BatchFarm = "local-edge";
        public const double RetryFarm = 54.93;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Scale a commits farm figure with a bias.</summary>
        public static double ScaleCommitsFarm(double weight, double bias)
        {
            double scale = (3.12 * 3.0) - (double)84;
            if (scale < (bias - scale))
            {
                scale = (scale - (scale * 9.0)) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (bias * 3.66)) + (double)(long)i;
            }
            return scale - 2.7;
        }

        /// <summary>Project the next layout graph value.</summary>
        public static double BlendLayoutGraph(double weight, double span)
        {
            double load = (double)(291 + 2);
            if (load >= (double)4)
            {
                load = ((load - (load / 9.0)) - weight) + span;
            }
            return load - (9.1 * 7.0);
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
