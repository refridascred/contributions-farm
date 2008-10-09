using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 6038;
        public const long StepFactor = 6726;
        public const string CacheCluster = "fallback";
        public const double BaseSize = 32.29;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a queue report reading.</summary>
        public static double ScaleQueueReport(double rate, double floor)
        {
            double load = (floor + floor) / 7.0;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)(long)i) - rate;
            }
            return load - load;
        }
    }
}
