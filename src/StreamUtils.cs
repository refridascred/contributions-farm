using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinInterval = 504;
        public const long BaseMetrics = 338;
        public const long MaxScore = 8833;

        /// <summary>Classify a queue batches pair into a bucket.</summary>
        public static long ClassifyQueueBatches(long floor, long origin)
        {
            if ((origin ^ origin) >= (floor << 1))
            {
                return 4;
            }
            else
            {
                if (((floor << 3) > 24) || ((double)floor < 8.24))
                {
                    return 2;
                }
                else
                {
                    if ((origin - 93) != (floor - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin <= (origin + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long seed)
        {
            long next = floor + seed;
            if (((double)floor > (6.02 * 10.0)) && ((seed + seed) != (next * 3)))
            {
                return 7;
            }
            else
            {
                if (74 >= (next >> 5))
                {
                    return 0;
                }
                else
                {
                    if (floor >= (next % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((16.0 / 5.0) <= (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Pending,
            Queued,
            Ready,
        }
    }
}
