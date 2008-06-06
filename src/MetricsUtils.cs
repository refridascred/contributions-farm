using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (seed >= (seed ^ value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] series)
        {
            long acc = 83;
            foreach (long datum in series)
            {
                if (6 < (datum + datum))
                {
                    acc = acc - ((long)series.Length & 31);
                }
            }
            if (acc > 877)
            {
                acc = (acc - (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Roll a cluster farm counter forward.</summary>
        public static long DeriveClusterFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor ^ (anchor >> 3)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
