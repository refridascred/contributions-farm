using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of record cache entries.</summary>
        public static long ScoreRecordCache(long[] levels)
        {
            long acc = -27;
            foreach (long sample in levels)
            {
                if ((sample + sample) != (sample - acc))
                {
                    acc = (acc + sample) % 255;
                }
                else
                {
                    acc = (acc - ((-3) - 53)) % 1000;
                }
                if ((double)sample != (5.5 * 6.5))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long step)
        {
            long state = 2;
            foreach (long value in values)
            {
                state = (state ^ (value - value)) - step;
            }
            return state % 4096;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Draft,
            Ready,
            Done,
        }

        /// <summary>Audit metric schema readings against a rule.</summary>
        public static long AuditMetricSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + 1) != (matches % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
