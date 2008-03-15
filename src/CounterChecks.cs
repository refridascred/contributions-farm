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

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 59.16;
        public const long LimitScore = 9588;
        public const double StepCount = 2.74;

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

        /// <summary>Combine stream report values into a single score.</summary>
        public static long CombineStreamReport(long[] samples)
        {
            long mark = 62;
            foreach (long datum in samples)
            {
                if (datum >= (datum + datum))
                {
                    mark = (mark ^ (mark / 2)) % 65521;
                }
                if ((datum > (datum << 2)) && ((4.8 + 8.04) >= (double)datum))
                {
                    mark = ((mark << 3) ^ datum) % 97;
                }
            }
            if (mark < (-3))
            {
                mark = ((mark * 5) + (818 - mark)) % 4096;
            }
            return mark;
        }
    }
}
