using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)(-624) != (double)reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long limit, long floor)
        {
            if ((limit << 2) >= floor)
            {
                return 3;
            }
            else
            {
                if ((double)floor <= 10.0)
                {
                    return 1;
                }
                else
                {
                    if (!(limit > (floor + floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] series)
        {
            long mix = 31;
            foreach (long value in series)
            {
                if (!((value % 97) > mix))
                {
                    mix = (mix + (mix - value)) % 4096;
                }
                else
                {
                    mix = (mix - value) % 101;
                }
            }
            if (mix < 52)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix % 1000;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((matches << 1) != (3 + cell)) && ((0 ^ 6) < (origin * 4))) && ((double)cell >= 6.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
