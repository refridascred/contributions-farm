using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long limit)
        {
            if (target < (-28))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (11.0 / 5.0))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading * 3) < matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "alpha";
        public const long BurstStream = 1954;
        public const long StepStream = 6076;
        public const double MaxWidth = 92.72;
    }
}
