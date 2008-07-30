using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Retry,
            Pending,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepLevel = 3487;
        public const double BatchSpan = 24.14;
        public const double IdleContext = 53.52;
        public const long StepWidth = 4211;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 7264;
        public const string BatchContext = "local-edge";
        public const double StepBudget = 83.43;
        public const long MinInterval = 2089;
        public const long MaxContext = 3896;

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double ratio, double floor)
        {
            double load = floor;
            if (load >= (double)326)
            {
                load = (load - load) - ratio;
            }
            else
            {
                load = load + (floor / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 0.66) - (double)(long)i;
            }
            return load + (double)6;
        }
    }
}
