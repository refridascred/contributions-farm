using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Pending,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((14.0 + 1.62) < (double)entry) && ((tally >> 3) <= entry)) && (((tally << 3) <= (entry + (long)readings.Length)) && ((long)readings.Length <= tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool CheckProfileWindowLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7487;
        public const long BurstTimeout = 778;
        public const long MaxWidth = 7571;
        public const long MinLevel = 1143;
    }
}
