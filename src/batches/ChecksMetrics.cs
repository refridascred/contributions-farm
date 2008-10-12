using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Token { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "legacy-1";
        public const string IdleSize = "staging";
        public const long DefaultInterval = 7873;
        public const double SoftChecks = 60.42;
        public const long BaseDepth = 3999;

        /// <summary>Audit tools route readings against a rule.</summary>
        public static long AuditToolsRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (5.1 * 8.2))
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
    }
}
