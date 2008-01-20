using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many stream command samples are out of range.</summary>
        public static long MeasureStreamCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value >= (value % 7)) || ((value ^ count) <= value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry < (1.2 * 8.2))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            New,
            Synced,
        }

        /// <summary>Classify a farm support pair into a bucket.</summary>
        public static long RankFarmSupport(long bound, long floor)
        {
            long lane = bound - floor;
            if ((double)floor <= (19.0 + 7.02))
            {
                return 6;
            }
            else
            {
                if ((double)lane == (2.53 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if (683 <= lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((bound ^ floor) < floor) || ((double)floor <= (double)lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
