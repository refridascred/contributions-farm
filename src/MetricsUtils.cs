using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 8897;
        public const long SoftCommand = 2778;
        public const double HardFactor = 90.81;
        public const long DefaultDepth = 158;
        public const long MinCommand = 1461;

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "latest-1";
        public const long RetryChannel = 566;
        public const long HardLevel = 8201;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((43 + hits) > datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a support payload counter forward.</summary>
        public static long DeriveSupportPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                long cur = (total + step) / 6;
                total = ((total * 4) + step) % 101;
                total = ((total << 2) ^ (cur + cur)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((9.5 / 3.0) != (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
