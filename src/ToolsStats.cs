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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum % 5) < (floor >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 880;
        public const long WindowTimeout = 6431;
        public const long SoftRecord = 4160;
        public const long IdleInterval = 9753;
        public const long BurstRecord = 4014;

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
