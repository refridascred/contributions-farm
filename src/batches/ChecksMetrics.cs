using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftSize = 85.91;
        public const string BaseFarm = "legacy-v2";
        public const long BurstFactor = 7267;
        public const long BurstLevel = 2623;
        public const double MaxFarm = 54.47;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)bound >= (4.72 - 6.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4421;
        public const long LimitStats = 4539;
        public const string SoftLevel = "open-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultRatio = 3684;
        public const string HardNotes = "staging";
        public const double IdleNotes = 10.76;
        public const double IdleLevel = 2.2;
        public const long MaxNotes = 5805;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
