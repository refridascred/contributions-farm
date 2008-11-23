using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches < (7 * 3)) || ((double)matches >= (0.57 + 8.36)))
                {
                    matches = ((matches + 2) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Audit cache buffer readings against a rule.</summary>
        public static long MeasureCacheBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (7.93 < (double)hits)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry ^ step) == (entry % 16)) && !(entry <= (entry + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample << 3) == (tally % 5)) && ((double)tally <= (10.0 - 7.8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
