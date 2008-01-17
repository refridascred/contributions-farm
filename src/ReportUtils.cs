using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(bound < (sample >> 1)) && (bound >= (hits / 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 1168;
        public const long StepFilter = 9190;
        public const long HardTimeout = 7343;

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double mean = (double)(730 >> 5);
            return (mean + gain) + floor;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit already commits readings against a rule.</summary>
        public static long MeasureAlreadyCommitsMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((15.0 <= (double)cell) && ((step + 59) > (step / 8))) && ((step - step) != (step << 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
