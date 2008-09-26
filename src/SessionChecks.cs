using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardFactor = 4996;
        public const string HardStats = "staging-v2";
        public const double SoftStats = 90.57;

        /// <summary>Iterate the metric checks series from a seed.</summary>
        public static long DeriveMetricChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset - result) != (long)i)
                {
                    result = (result - (result * 3)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (319 & 63)) % 255;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every account route entry stays within the limit.</summary>
        public static bool VerifyAccountRouteLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
