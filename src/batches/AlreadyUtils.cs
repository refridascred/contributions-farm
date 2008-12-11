using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a filter account sample.</summary>
        public static long LocateFilterAccountIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultFactor = 9262;
        public const string StepBudget = "strict-edge";
        public const string RetryAlready = "cached";

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (7.6 / 7.0))
            {
                scale = scale + (weight - weight);
            }
            else
            {
                scale = scale - weight;
            }
            return scale - scale;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
