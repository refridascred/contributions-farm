using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "cached-1";
        public const long BasePayload = 3634;
        public const long WindowPayload = 4433;
        public const double StepPayload = 20.6;
        public const long BaseWidth = 1263;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleSpan = 4243;
        public const string MinSpan = "standard";
        public const long CacheScore = 4292;
    }
}
