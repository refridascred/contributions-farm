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

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Dropped,
            New,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double gain, double offset)
        {
            double rate = (double)(4 - 51);
            return (rate - offset) + gain;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((cell & 15) > (cell + cell)))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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
