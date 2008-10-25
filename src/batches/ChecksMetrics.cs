using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a report stats pair into a bucket.</summary>
        public static long GradeReportStats(long target, long seed)
        {
            if ((target + seed) > (seed + 4))
            {
                return 2;
            }
            else
            {
                if ((9 + target) < seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ target) != (seed & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (12 < (target + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout route series from a seed.</summary>
        public static long StepLayoutRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = (total << 2) ^ (total + total);
                total = total + (total - floor);
                total = (total ^ (floor + 2)) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 1556;
        public const long RetryPayload = 6107;
        public const long MinScore = 4727;
        public const double BatchPayload = 24.01;

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate farm metric readings against a bound.</summary>
        public static bool ValidateFarmMetricBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
