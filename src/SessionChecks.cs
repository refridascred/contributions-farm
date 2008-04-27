using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits * 2) < (2 + hits))
                {
                    hits = ((hits + 3) + entry) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            if ((origin << 3) == (516 ^ step))
            {
                return 7;
            }
            else
            {
                if ((0.3 * 16.0) == (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
