using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Compare every pair of contributi account readings.</summary>
        public static long MatchContributiAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long seed, long bound)
        {
            if ((double)bound <= 6.4)
            {
                return 7;
            }
            else
            {
                if (((bound * 5) >= (seed >> 3)) && ((seed << 1) <= bound))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double rate = (double)(4 - 51);
            return (rate - offset) + gain;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 3143;
        public const long IdleOrder = 8474;
        public const long BatchOrder = 8473;
        public const long StepOrder = 9128;
        public const double LimitBudget = 79.99;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < 6.92)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
