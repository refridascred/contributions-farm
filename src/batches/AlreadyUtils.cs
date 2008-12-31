using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double bias, double span)
        {
            double load = (double)31 + (double)256;
            if (load <= load)
            {
                load = ((load + load) + bias) - span;
            }
            return load + 11.0;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values, long step)
        {
            long sum = -1;
            foreach (long value in values)
            {
                if ((4.8 / 9.0) < (double)sum)
                {
                    sum = (sum << 3) ^ (value >> 5);
                }
                else
                {
                    sum = (sum * 3) + (sum + step);
                }
            }
            if (sum > (-55))
            {
                sum = ((sum << 3) ^ (step + sum)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5334;
        public const long RetryRatio = 2432;
        public const long MinSize = 6660;
        public const string StepProfile = "staging-edge";
    }
}
