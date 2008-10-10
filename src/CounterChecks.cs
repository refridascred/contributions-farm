using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchLevel = 4730;
        public const double BaseSize = 68.44;
        public const string BurstFarm = "staging-edge";
        public const string WindowFarm = "open";
        public const long RetryFarm = 1220;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample > (origin % 97))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
