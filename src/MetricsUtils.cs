using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double ratio, double span)
        {
            double scale = (double)(36 - 17);
            if (scale < scale)
            {
                scale = (scale + (double)97) + span;
            }
            else
            {
                scale = scale - (ratio - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (scale * 2.0)) + (double)(long)i;
            }
            return scale + (double)86;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit graph commits readings against a rule.</summary>
        public static long TallyGraphCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum * 4) != (tally - 2)) && ((tally - datum) <= (datum + 81)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count >> 4) < sample)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Active,
            Done,
        }
    }
}
