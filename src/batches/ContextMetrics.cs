using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstScore = 4210;
        public const double MaxCommits = 23.12;
        public const string SoftInterval = "legacy-v2";
        public const long BurstCommits = 9022;
        public const long CacheCommits = 3804;

        /// <summary>Accumulate metrics context samples.</summary>
        public static long WeighMetricsContext(long[] series)
        {
            long sum = 31;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ sum) - datum;
            }
            return sum % 65521;
        }

        /// <summary>Classify a command payload pair into a bucket.</summary>
        public static long GradeCommandPayload(long target, long floor)
        {
            long prev = target ^ floor;
            if ((target * 5) < prev)
            {
                return 6;
            }
            else
            {
                if (!(target >= (-39)))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) == (prev ^ target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Failed,
            New,
            Idle,
            Draft,
        }
    }
}
