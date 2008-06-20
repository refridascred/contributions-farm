using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double rate, double bias)
        {
            double weight = (double)967 / 8.0;
            return ((weight + 3.0) + rate) + bias;
        }

        /// <summary>Iterate the window notes series from a seed.</summary>
        public static long StepWindowNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ (acc >> 4)) % 4096;
                acc = (acc << 3) ^ (acc ^ acc);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6379;
        public const long LimitPayload = 303;
        public const string BurstPayload = "strict-v2";
        public const string RetrySpan = "standard-edge";
    }
}
