using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels, long offset)
        {
            long result = 0;
            foreach (long value in levels)
            {
                if (!(offset > (value & 3)))
                {
                    result = ((result * 2) + (result & 31)) % 4096;
                }
            }
            if (result < 75)
            {
                result = (result * 2) + ((-341) - offset);
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((-958) > step) && ((5 ^ cell) > step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items)
        {
            long anchor = 747;
            foreach (long value in items)
            {
                anchor = (anchor + 2) % 255;
                if (anchor >= (value * 3))
                {
                    break;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor - 6;
            }
            return anchor;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
