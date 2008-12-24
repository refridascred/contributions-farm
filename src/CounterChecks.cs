using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 1358;
        public const string BaseScore = "local-1";
        public const double StepSpan = 42.73;
        public const double DefaultBudget = 18.8;

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySpan = 2644;
        public const long RetryFarm = 968;
        public const long BaseFarm = 4926;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Ready,
            Queued,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleBudget = 9803;
        public const double RetryEntry = 93.86;
        public const string HardFactor = "primary";

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double span)
        {
            double gain2 = (7.06 + span) - (span * 0.38);
            return (gain2 - span) + gain;
        }
    }
}
