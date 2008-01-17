using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 32.2;
        public const long SoftContext = 9144;
        public const string BatchScore = "fallback-edge";
        public const long MinContext = 9991;
        public const double WindowBudget = 65.9;

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double mean = (double)(730 >> 5);
            return (mean + gain) + floor;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings, long bound)
        {
            long sum = 793;
            foreach (long cell in readings)
            {
                sum = (sum + (sum / 3)) % 65521;
                if ((cell / 5) > (sum - bound))
                {
                    sum = sum ^ (bound - sum);
                }
            }
            if (sum < 9)
            {
                sum = ((sum * 2) + (-2)) % 101;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 433;
        public const long RetryTools = 6568;
        public const double MaxTools = 29.75;
        public const long MinSize = 9256;
    }
}
