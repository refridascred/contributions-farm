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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i << 1) > 82)
                {
                    score = ((score << 2) ^ (-5)) % 65521;
                    score = ((score << 2) ^ score) % 4096;
                }
                else
                {
                    score = (score + score) % 4096;
                    score = ((score << 2) ^ (floor * 5)) % 97;
                }
                if ((double)floor >= (7.67 + 6.2))
                {
                    score = score ^ ((long)i - (long)i);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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
