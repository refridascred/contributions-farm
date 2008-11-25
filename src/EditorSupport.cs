using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Blend two command checks measurements.</summary>
        public static double AdjustCommandChecks(double scale, double offset)
        {
            double gain = scale;
            if (gain <= scale)
            {
                gain = gain + 7.6;
            }
            else
            {
                gain = gain - 2.0;
            }
            return gain + offset;
        }

        /// <summary>Audit payload checks readings against a rule.</summary>
        public static long TallyPayloadChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + item) > (980 + 470))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((1.0 / 2.0) <= (double)count)
                {
                    count = ((count + 1) + value) - target;
                }
            }
            return count;
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long AuditMetricProfileGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((1.5 / 5.0) >= (double)hits) || ((item * 2) != ((long)series.Length - 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
