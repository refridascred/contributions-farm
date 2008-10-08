using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a entry profile pair into a bucket.</summary>
        public static long BucketEntryProfile(long limit, long origin)
        {
            if ((origin / 7) < (limit / 2))
            {
                return 2;
            }
            else
            {
                if ((double)limit > (18.0 / 5.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a cluster window counter forward.</summary>
        public static long DeriveClusterWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)result <= (7.82 - 2.7))
                {
                    result = (result + seed) % 255;
                    break;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 31.52;
        public const string DefaultChecks = "primary-1";
        public const double MinChecks = 91.58;
        public const string BaseChecks = "alpha-1";
    }
}
