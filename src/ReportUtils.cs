using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = mix ^ (mix << 1);
                mix = mix ^ (mix + step);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
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

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Paused,
            Dropped,
            Pending,
            Failed,
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
