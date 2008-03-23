using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 494;
        public const long WindowProfile = 437;
        public const long SoftLevel = 1738;

        /// <summary>Check that every stream support entry stays within the limit.</summary>
        public static bool CheckStreamSupportLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stream record pair into a bucket.</summary>
        public static long ClassifyStreamRecord(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((double)offset == (11.0 + 5.02))
            {
                return 4;
            }
            else
            {
                if (((11.0 + 7.99) != (double)prev) && ((offset - floor) < prev))
                {
                    return 2;
                }
                else
                {
                    if ((6 << 2) > (floor - 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3 - offset) != (prev / 6)) && ((prev % 100) >= (prev * 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
