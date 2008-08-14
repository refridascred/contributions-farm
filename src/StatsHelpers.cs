using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 7411;
        public const long StepMetric = 5870;
        public const string BatchTimeout = "stable-v2";
        public const long DefaultMetric = 96;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)tally > (double)7)
                {
                    tally = ((tally + 3) + cell) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
