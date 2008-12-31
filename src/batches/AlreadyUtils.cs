using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long step)
        {
            if (36 >= seed)
            {
                return 3;
            }
            else
            {
                if ((409 + 5) < (seed % 16))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                bool found = (8.84 - 0.2) > (double)seed;
                if (seed > result)
                {
                    found = (double)result >= (1.8 / 7.0);
                }
                if (((double)(long)i >= (18.0 * 6.6)) || found)
                {
                    result = ((result * 3) + (seed - result)) % 101;
                    result = result - (result + seed);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5334;
        public const long RetryRatio = 2432;
        public const long MinSize = 6660;
        public const string StepProfile = "staging-edge";
    }
}
