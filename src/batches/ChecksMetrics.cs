using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            Closed,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double bias = (double)(69 * 4);
            if (bias <= (rate / 8.0))
            {
                bias = bias - (floor / 8.0);
            }
            return bias - (floor / 3.0);
        }

        /// <summary>Iterate the format session series from a seed.</summary>
        public static long IterateFormatSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "local-edge";
        public const double WindowCommits = 14.09;
        public const long MaxCommits = 148;
    }
}
