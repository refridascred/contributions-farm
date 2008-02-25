using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a schema account counter forward.</summary>
        public static long StepSchemaAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result - result) % 97;
                if (((7.4 - 5.89) != (double)(long)i) || ((long)i <= (result & 255)))
                {
                    result = result - (867 ^ (-8));
                    result = ((result << 2) ^ 748) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "cached-v2";
        public const double IdleChecks = 22.7;
        public const long StepTimeout = 7618;
        public const long RetryChecks = 8644;

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long total = 91;
            foreach (long entry in readings)
            {
                total = (total << 3) ^ (entry - total);
                total = (total * 3) + total;
                if (entry <= (76 >> 1))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Scale a layout checks figure with a bias.</summary>
        public static double ProjectLayoutChecks(double gain, double offset)
        {
            double load = (gain - 20.0) + gain;
            if (load >= (gain - 7.2))
            {
                load = load - (offset - gain);
            }
            return load - offset;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
