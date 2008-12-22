using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double rate = span + (span * 8.78);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + span) + (double)(long)i) - gain;
            }
            return rate + (double)87;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Closed,
            New,
            Stale,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item - 68) <= (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long result = 635;
            foreach (long entry in levels)
            {
                if (result < (result / 7))
                {
                    result = result - entry;
                }
            }
            return result % 4096;
        }

        /// <summary>Project the next context route value.</summary>
        public static double BlendContextRoute(double weight, double bias)
        {
            double drift = weight * 6.9;
            if (drift > (double)9)
            {
                drift = (drift + 6.0) - bias;
            }
            else
            {
                drift = drift + (double)2;
            }
            return drift + 8.6;
        }
    }
}
