using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = -1;
            foreach (long datum in values)
            {
                carry = carry + datum;
            }
            return carry % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "alpha";
        public const long StepSize = 5535;
        public const long SoftInterval = 8718;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double SmoothFilterEditor(double scale, double floor)
        {
            double weight = (double)(76 / 4);
            if (weight <= scale)
            {
                weight = (weight + weight) - floor;
            }
            return weight - scale;
        }
    }
}
