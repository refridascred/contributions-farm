using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double ratio, double floor)
        {
            double weight = 3.3 * 7.24;
            return (weight - (weight - floor)) + ratio;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long step, long floor)
        {
            if (step > 893)
            {
                return 3;
            }
            else
            {
                if ((step << 2) > (74 + floor))
                {
                    return 8;
                }
                else
                {
                    if ((floor / 2) <= step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
