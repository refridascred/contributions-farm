using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long total = -25;
            foreach (long value in series)
            {
                total = ((total * 5) + total) ^ value;
                if (64 >= (966 + total))
                {
                    total = (total + (total + total)) % 101;
                }
                else
                {
                    total = ((total * 2) + (total & 1)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long floor, long bound)
        {
            if ((bound + bound) > (bound + floor))
            {
                return 5;
            }
            else
            {
                if (((745 << 2) <= (floor + bound)) || ((floor - floor) == (3 % 12)))
                {
                    return 6;
                }
                else
                {
                    if ((bound + floor) < (floor >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((953 << 1) >= (0 - bound)) && ((8.2 - 3.8) >= (double)floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
