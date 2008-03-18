using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryLevel = 40.92;
        public const long DefaultRatio = 5345;
        public const string RetryCount = "alpha";
        public const double BurstTimeout = 54.51;

        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long MeasureSupportMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (20.0 - 16.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] series, long step)
        {
            long sum = 670;
            foreach (long reading in series)
            {
                sum = ((sum + (sum + step)) % 4096) - reading;
            }
            return sum;
        }

        /// <summary>Classify a support route pair into a bucket.</summary>
        public static long BucketSupportRoute(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (!((bound << 2) < (bound2 + offset)))
            {
                return 6;
            }
            else
            {
                if (((7 / 9) >= (bound + bound)) && ((4 % 100) > offset))
                {
                    return 4;
                }
                else
                {
                    if (!(bound2 < (offset + bound2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound > (bound2 - bound2)) && ((bound2 + bound2) <= (bound - 800)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate profile schema samples.</summary>
        public static long TallyProfileSchema(long[] levels)
        {
            long anchor = 94;
            foreach (long datum in levels)
            {
                anchor = (anchor - (anchor - datum)) % 101;
                anchor = anchor ^ anchor;
                if ((datum << 1) >= (anchor + datum))
                {
                    anchor = anchor ^ (datum >> 5);
                }
                else
                {
                    anchor = anchor ^ (datum - datum);
                }
                if ((3 / 9) <= (anchor % 12))
                {
                    break;
                }
            }
            if (anchor < 26)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
            }
            return anchor % 4096;
        }
    }
}
