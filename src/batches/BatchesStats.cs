using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster githubfarm measurements.</summary>
        public static double SmoothClusterGithubfarm(double gain, double offset)
        {
            double drift = offset / 8.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (17.0 + drift)) + (double)(long)i) + gain;
            }
            return drift - (double)86;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (long)i) % 1000;
                carry = (carry - (924 - seed)) % 255;
                carry = (carry << 3) ^ 82;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
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
