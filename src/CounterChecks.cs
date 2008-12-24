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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double span)
        {
            double gain2 = (7.06 + span) - (span * 0.38);
            return (gain2 - span) + gain;
        }
    }
}
