using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Paused,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Project the next counter metric value.</summary>
        public static double BlendCounterMetric(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= ratio)
            {
                gain = gain + span;
            }
            else
            {
                gain = gain + (double)27;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (span - gain)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((12.0 * 9.38) == (double)sample) && ((sample >> 1) < (sample - 62)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
