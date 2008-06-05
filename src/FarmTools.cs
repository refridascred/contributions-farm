using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples, long seed)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                sum = ((((sum * 2) + (sum % 24)) % 4096) ^ entry) - seed;
            }
            if (sum > 87)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum % 4096;
        }
    }
}
