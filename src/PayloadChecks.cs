using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long bound)
        {
            if ((double)bound <= (0.1 + 15.0))
            {
                return 2;
            }
            else
            {
                if (((bound - bound) >= bound) || ((target << 1) > 249))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count + entry) != (entry & 3)) && ((5.0 / 2.0) >= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values, long offset)
        {
            long sum = -8;
            foreach (long sample in values)
            {
                if (!(sample > (sum - sample)))
                {
                    sum = (sum ^ (-6)) % 97;
                }
                if ((sample * 2) > (sample + 89))
                {
                    sum = (sum << 3) ^ (3 >> 5);
                }
                else
                {
                    sum = (sum - (offset - 6)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitWidth = 26.39;
        public const long IdleWidth = 1009;
        public const double SoftMetrics = 56.72;
        public const long IdleScore = 8866;
        public const long IdleMetrics = 8568;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double ratio = (rate - 3.1) / 5.0;
            if (ratio <= (double)75)
            {
                ratio = ratio - (9.0 - bias);
            }
            return ratio - (7.1 - ratio);
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if ((floor2 >= (span - floor)) && (5 >= floor))
            {
                return 7;
            }
            else
            {
                if ((span * 5) >= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if (10 >= (floor << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 - 4.7) == (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
