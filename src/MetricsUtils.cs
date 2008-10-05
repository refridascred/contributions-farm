using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metric farm entries that pass the check.</summary>
        public static long TallyMetricFarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (15.0 <= (double)tally)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Measure how many already cluster samples are out of range.</summary>
        public static long CountAlreadyClusterMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((limit / 3) < (seen % 8))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Combine channel commits values into a single score.</summary>
        public static long TallyChannelCommits(long[] levels, long origin)
        {
            long result = 348;
            foreach (long reading in levels)
            {
                if ((origin * 5) >= (result >> 2))
                {
                    result = (result << 2) ^ (reading + reading);
                }
                else
                {
                    result = result - (result + reading);
                }
                if ((reading < (reading & 3)) && ((657 + reading) >= reading))
                {
                    break;
                }
            }
            if (result < 813)
            {
                result = ((result * 3) + origin) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftRatio = 71.42;
        public const long LimitTimeout = 3356;
        public const long BatchRatio = 9023;
        public const long LimitQueue = 8689;
    }
}
