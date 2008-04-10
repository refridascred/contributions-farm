using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "latest";
        public const double StepCache = 58.25;
        public const long BaseSpan = 6698;

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetrySpan = "latest-1";
        public const long DefaultLayout = 4934;
        public const string DefaultTimeout = "strict-edge";

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
