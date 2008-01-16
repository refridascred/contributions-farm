using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long origin)
        {
            long span = limit ^ origin;
            if ((limit - origin) == (origin << 2))
            {
                return 4;
            }
            else
            {
                if (((double)span > (2.47 - 9.3)) && ((span * 3) == (span + span)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + limit) != (origin + span))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit + limit) >= (limit >> 5)) && ((origin + 5) >= limit))
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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.9 / 2.0) > (double)item) || (matches > target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] samples)
        {
            long sum = 782;
            foreach (long sample in samples)
            {
                sum = sum - sample;
                if (sum >= (sum + sum))
                {
                    sum = (sum - (sample + 4)) % 4096;
                }
                if (7.8 >= (double)sum)
                {
                    break;
                }
            }
            if (sum > 945)
            {
                sum = sum - (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
