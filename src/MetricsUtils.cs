using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long sum = 0;
            foreach (long sample in items)
            {
                if (((origin / 7) < origin) && ((sample + origin) >= origin))
                {
                    sum = sum ^ (49 >> 2);
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every graph metrics entry stays within the limit.</summary>
        public static bool ValidateGraphMetricsRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series)
        {
            long result = 24;
            foreach (long cell in series)
            {
                if ((36 ^ 51) < cell)
                {
                    result = ((result * 2) + 82) % 101;
                }
                if ((cell + (long)series.Length) > (cell + result))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result - (38 * 5)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
