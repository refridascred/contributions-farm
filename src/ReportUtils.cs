using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Draft,
            Ready,
            New,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double load = floor;
            if (load > load)
            {
                load = load - scale;
            }
            return load - scale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepRatio = 8940;
        public const double BurstSpan = 73.81;
        public const long RetryCluster = 7345;
        public const long StepSpan = 8545;

        /// <summary>Iterate the profile stats series from a seed.</summary>
        public static long SeriesProfileStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (limit & 63)) % 255;
                carry = carry + carry;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
