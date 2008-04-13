using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleCount = 4931;
        public const long MinChecks = 773;
        public const double BaseChecks = 6.78;
        public const long HardInterval = 1528;

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (((acc * 5) + (target - acc)) % 4096) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    acc = (acc * 2) + 4;
                    acc = ((acc * 2) + (long)i3) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long MeasureLayoutMetricsGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((double)sample == (4.53 * 11.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double ratio, double offset)
        {
            double load = offset / 6.0;
            if (load < offset)
            {
                load = (load - offset) - ratio;
            }
            else
            {
                load = load + load;
            }
            return load + offset;
        }
    }
}
