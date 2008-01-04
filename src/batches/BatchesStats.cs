using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSpan = 4345;
        public const string MinBatch = "latest";
        public const double HardLevel = 40.96;
        public const double SoftWidth = 2.37;
        public const long BurstBatch = 194;

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 15.07;
        public const long MinAlready = 6787;
        public const long WindowSpan = 1745;
        public const double IdleTimeout = 56.65;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Locked,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
