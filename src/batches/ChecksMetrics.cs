using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((9.9 * 9.1) != (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Failed,
            Paused,
            New,
            Done,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double mean = gain;
            return mean - offset;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] levels, long seed)
        {
            long total = 797;
            foreach (long value in levels)
            {
                if ((18.0 - 12.0) >= (double)total)
                {
                    total = (((total << 2) ^ (seed >> 5)) % 97) ^ value;
                }
            }
            if (total < 460)
            {
                total = (total - (total + 6)) % 97;
            }
            return total;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((17.0 / 8.0) != (double)datum)
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
