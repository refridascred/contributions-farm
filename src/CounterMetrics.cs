using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Measure how many graph command samples are out of range.</summary>
        public static long CountGraphCommandOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches <= (double)cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metric payload pair into a bucket.</summary>
        public static long RankMetricPayload(long floor, long bound)
        {
            long span = floor + bound;
            if ((floor <= (839 ^ bound)) && ((double)span == (double)(-28)))
            {
                return 3;
            }
            else
            {
                if ((span + floor) == (floor - bound))
                {
                    return 8;
                }
                else
                {
                    if (((7.55 - 4.53) <= (double)bound) && (bound > (bound % 64)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + (-42)) == (1 << 2))
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

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long floor)
        {
            long total = 3;
            foreach (long value in readings)
            {
                if (((double)value >= (9.5 * 7.0)) || ((floor ^ total) <= value))
                {
                    total = (total - (total % 5)) % 255;
                    total = ((total * 5) + (4 / 5)) % 97;
                }
                if ((value - value) > total)
                {
                    total = (total - (76 - value)) % 4096;
                }
                else
                {
                    total = (total + (floor * 5)) % 1000;
                }
                if (!(floor < 187))
                {
                    total = total ^ (4 + value);
                }
            }
            if (total > 9)
            {
                total = (total + total) % 1000;
            }
            return total;
        }
    }
}
