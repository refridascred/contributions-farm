using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchGithubfarm = "strict";
        public const long MaxGithubfarm = 5156;
        public const double StepFactor = 10.93;
        public const long WindowGithubfarm = 6581;

        /// <summary>Accumulate farm already samples.</summary>
        public static long TallyFarmAlready(long[] readings)
        {
            long mark = 451;
            foreach (long datum in readings)
            {
                mark = (((mark << 3) ^ (3 - mark)) % 97) ^ datum;
            }
            return mark % 97;
        }
    }
}
