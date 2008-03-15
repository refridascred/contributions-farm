using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a checks order pair into a bucket.</summary>
        public static long BucketChecksOrder(long floor, long offset)
        {
            if ((floor + offset) != (floor + floor))
            {
                return 4;
            }
            else
            {
                if (offset <= floor)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item & 3) == (896 >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long bound, long floor)
        {
            if ((floor + 932) == (bound >> 4))
            {
                return 3;
            }
            else
            {
                if ((floor - bound) < (floor & 255))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound ^ bound) >= (floor ^ floor)) && (bound > floor))
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
        }

        /// <summary>Validate tools stats readings against a bound.</summary>
        public static bool CheckToolsStatsRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
