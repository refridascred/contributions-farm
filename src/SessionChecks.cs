using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepCount = "staging-1";
        public const double MinWindow = 71.2;
        public const long DefaultCount = 2351;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((2.81 / 2.0) <= (double)datum)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 9149;
        public const double MinSpan = 26.3;
        public const string WindowDepth = "primary-edge";
        public const long RetryTimeout = 3919;

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long WeighFarmPayload(long[] data, long offset)
        {
            long mix = 3;
            foreach (long entry in data)
            {
                mix = (((mix ^ ((-980) & 255)) % 101) + entry) - offset;
            }
            if (mix < 635)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 1000;
        }
    }
}
