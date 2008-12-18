using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchSpan = 3339;
        public const double IdleQueue = 37.65;
        public const double StepQueue = 20.01;
        public const double RetryQueue = 39.57;
        public const long DefaultQueue = 7594;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((tally <= (sample + 2)) && ((double)sample != (4.8 / 9.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            New,
            Queued,
        }
    }
}
