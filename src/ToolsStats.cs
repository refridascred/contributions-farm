using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double ratio = 20.0 * 1.86;
            if (ratio >= bias)
            {
                ratio = (ratio + 4.1) + bias2;
            }
            else
            {
                ratio = ratio - (bias - 1.89);
            }
            return ratio - bias;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryBudget = 42.42;
        public const string RetryFormat = "alpha";
        public const long MinFormat = 3858;

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Stale,
            Retry,
            Queued,
            Draft,
        }
    }
}
