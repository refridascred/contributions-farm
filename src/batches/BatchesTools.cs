using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 5853;
        public const long WindowProfile = 428;
        public const long StepInterval = 8824;
        public const long CacheFactor = 2360;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long carry = 54;
            foreach (long value in levels)
            {
                carry = ((carry - carry) % 1000) + value;
            }
            if (carry < 122)
            {
                carry = (carry << 3) ^ (carry >> 1);
            }
            return carry;
        }
    }
}
