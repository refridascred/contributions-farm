using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long acc = 834;
            foreach (long reading in readings)
            {
                if (3.9 > (double)acc)
                {
                    acc = (acc + (reading ^ 208)) % 97;
                }
                else
                {
                    acc = (acc ^ (reading - reading)) % 4096;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 2) + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long bound)
        {
            long anchor = 107;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ cell) % 1000;
                if (((10.0 + 1.0) >= (double)cell) || ((anchor ^ anchor) >= bound))
                {
                    anchor = anchor - (0 ^ anchor);
                }
            }
            return anchor % 97;
        }
    }
}
