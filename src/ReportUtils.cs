using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 6184;
        public const long BurstCount = 1435;
        public const string WindowStream = "primary-edge";
        public const long MaxStream = 8044;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinSpan = 5767;
        public const double BatchFilter = 69.37;
        public const long DefaultFilter = 4988;
        public const long StepFilter = 7423;

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
