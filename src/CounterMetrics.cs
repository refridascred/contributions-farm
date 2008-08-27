using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the farm token entries that pass the check.</summary>
        public static long AuditFarmTokenOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally - offset) < offset)
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric layout series from a seed.</summary>
        public static long IterateMetricLayout(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the already schema series from a seed.</summary>
        public static long DeriveAlreadySchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!((origin - (-7)) <= (origin - anchor)))
                {
                    anchor = (anchor ^ (origin / 3)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
