using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of filter stats entries.</summary>
        public static long ScoreFilterStats(long[] data, long origin)
        {
            long total = 897;
            foreach (long reading in data)
            {
                if (((origin % 3) < (total ^ reading)) && (total < (reading & 255)))
                {
                    total = ((total * 3) + (152 >> 4)) % 101;
                    break;
                }
                if ((-233) >= (791 + reading))
                {
                    total = total - (total + 0);
                }
                else
                {
                    total = ((total * 2) + (total >> 3)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Synced,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            New,
            Closed,
            Paused,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Derive the next checks metrics value from a seed.</summary>
        public static long SeriesChecksMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                long prev = (step + 0) - acc;
                acc = (acc - (prev + 37)) % 4096;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
