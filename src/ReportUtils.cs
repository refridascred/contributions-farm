using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Idle,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryWidth = 1721;
        public const long StepSize = 8148;
        public const long WindowScore = 922;
        public const long MinScore = 3721;
        public const long WindowSession = 332;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double weight, double bias)
        {
            double load = weight;
            if (load <= (load / 8.0))
            {
                load = load - (weight - load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (double)35;
        }
    }
}
