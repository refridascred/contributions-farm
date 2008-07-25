using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = result - (result - result);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a batch filter figure with a bias.</summary>
        public static double SmoothBatchFilter(double rate, double floor)
        {
            double ratio = floor;
            if (ratio >= (rate + rate))
            {
                ratio = ratio - floor;
            }
            return ratio + (rate / 9.0);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Queued,
            Pending,
            Done,
            Draft,
        }
    }
}
