using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long offset)
        {
            long anchor = 8;
            foreach (long entry in values)
            {
                if ((anchor * 5) >= (entry / 6))
                {
                    anchor = ((anchor - (anchor & 3)) % 255) + offset;
                }
            }
            if (anchor < 814)
            {
                anchor = ((anchor * 2) + 9) % 1000;
            }
            return anchor % 65521;
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

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstTimeout = "stable-1";
        public const long BaseCluster = 8168;
        public const long MaxScore = 5128;
    }
}
