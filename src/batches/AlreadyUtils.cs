using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Active,
            New,
            Pending,
            Retry,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double drift = gain;
            if (drift <= 5.8)
            {
                drift = (drift + drift) + floor;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (4.0 - drift)) + (double)(long)i;
            }
            return drift + (9.9 - 4.0);
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a queue metric reading by value.</summary>
        public static long LookupQueueMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
