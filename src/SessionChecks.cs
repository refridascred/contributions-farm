using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading <= (15.0 + 6.0)) && (((long)values.Length << 2) >= (target + 540)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next tools route value.</summary>
        public static double ScaleToolsRoute(double ratio, double floor)
        {
            double load = (double)9;
            if (load > (9.67 - load))
            {
                load = (load + (double)1) + ratio;
            }
            else
            {
                load = load - (floor / 8.0);
            }
            return load - (floor + floor);
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
