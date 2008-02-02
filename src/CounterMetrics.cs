using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long step, long offset)
        {
            long next = step - offset;
            if (((next >> 1) > next) && (offset < (step & 7)))
            {
                return 5;
            }
            else
            {
                if ((20.0 - 6.1) == (double)next)
                {
                    return 3;
                }
                else
                {
                    if ((next >= offset) && (offset >= next))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset & 3) > offset) || ((offset + next) != (next >> 1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftLevel = 1415;
        public const long RetryFactor = 2890;
        public const long BaseFactor = 5719;

        /// <summary>Measure how many farm profile samples are out of range.</summary>
        public static long CountFarmProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((((9.05 - 5.1) > (double)sample) && ((18.0 / 6.0) == (double)sample)) || ((count + (-5)) <= (sample ^ sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell % 8) != (seen << 3))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
