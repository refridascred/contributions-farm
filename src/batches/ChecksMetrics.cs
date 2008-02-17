using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Synced,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Adjust a queue profile reading.</summary>
        public static double ScaleQueueProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)18)
            {
                load = (load + scale) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading <= (hits >> 5))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
