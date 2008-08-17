using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] samples, long offset)
        {
            long anchor = 41;
            foreach (long cell in samples)
            {
                if ((anchor << 1) > (anchor + 65))
                {
                    anchor = ((anchor * 4) + (offset / 3)) % 255;
                }
                else
                {
                    anchor = (anchor - (cell * 2)) % 4096;
                }
                anchor = (anchor + (cell + 5)) % 97;
            }
            if (anchor > 32)
            {
                anchor = (anchor - (offset << 3)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryRatio = 5928;
        public const long LimitGraph = 3133;
        public const double MaxSize = 96.97;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Draft,
            Paused,
        }
    }
}
