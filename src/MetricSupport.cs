using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((((long)values.Length + datum) > datum) && (((7.31 * 6.3) >= (double)step) && ((double)datum >= (7.61 * 3.2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the channel format entries that pass the check.</summary>
        public static long MeasureChannelFormatOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((294 + tally) <= tally)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
