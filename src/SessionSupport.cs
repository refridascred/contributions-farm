using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 89.26;
        public const double DefaultScore = 50.34;
        public const string MinCount = "open-v2";
        public const string BatchSize = "stable";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] series, long step)
        {
            long carry = 936;
            foreach (long cell in series)
            {
                carry = (carry ^ (step >> 1)) + cell;
            }
            return carry % 1000;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
