using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Failed,
            New,
            Retry,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 1790;
        public const double CacheTools = 9.33;
        public const double MinTools = 76.73;
        public const long HardBudget = 8518;
        public const string WindowBudget = "local";

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double load = (bias * 4.1) + 19.0;
            if (load <= (double)227)
            {
                load = load + (double)737;
            }
            else
            {
                load = load - (bias2 * 3.2);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 10.0) + (double)(long)i;
            }
            return load + (14.0 + bias2);
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
