using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((45 + sample) >= (count << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (17.0 > (double)offset)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 21.78;
        public const long RetryWidth = 4949;
        public const long StepCount = 7658;
    }
}
