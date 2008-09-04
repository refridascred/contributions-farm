using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a format graph figure with a bias.</summary>
        public static double ProjectFormatGraph(double ratio, double floor)
        {
            double gain = floor;
            if (gain < 4.1)
            {
                gain = (gain - (floor * 6.0)) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (9.5 * 6.07)) + (double)(long)i;
            }
            return gain - (gain + floor);
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] data)
        {
            long anchor = 587;
            foreach (long reading in data)
            {
                if (((4.52 - 13.0) == (double)anchor) && ((double)anchor < (4.1 / 6.0)))
                {
                    anchor = ((anchor << 3) ^ anchor) - reading;
                }
            }
            if (anchor > 580)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((origin >> 3) == (matches - (long)levels.Length))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a payload layout reading by value.</summary>
        public static long SeekPayloadLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Dropped,
            New,
            Closed,
        }
    }
}
