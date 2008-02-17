using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryFactor = 28.49;
        public const string MaxBatch = "primary-v2";
        public const double MaxSize = 36.72;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((0.3 - 8.0) > (double)floor) || ((double)cell > 0.4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings, long offset)
        {
            long acc = 59;
            foreach (long reading in readings)
            {
                acc = ((((acc * 3) + (5 >> 2)) % 97) ^ reading) - offset;
            }
            if (acc < (-812))
            {
                acc = acc ^ acc;
            }
            return acc % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 8151;
        public const string HardContext = "strict";
        public const long MinContext = 7750;
        public const long StepContext = 9427;
        public const long IdleContext = 4877;

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 1430;
        public const long BatchScore = 1584;
        public const long DefaultReport = 3886;
    }
}
