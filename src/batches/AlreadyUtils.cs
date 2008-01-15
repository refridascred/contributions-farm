using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((101 + tally) > (tally % 12))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "open-1";
        public const double HardSpan = 76.35;
        public const string WindowRatio = "local";
        public const long BaseCluster = 8764;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long acc = 47;
            foreach (long entry in samples)
            {
                if ((entry & 3) < (acc + 3))
                {
                    acc = (acc ^ (9 - acc)) % 97;
                }
                if ((acc >> 5) != (acc << 3))
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Count the window metric entries that pass the check.</summary>
        public static long TallyWindowMetricHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (4.5 < (double)seen)
                {
                    seen = ((seen + 1) ^ reading) - floor;
                }
            }
            return seen;
        }
    }
}
