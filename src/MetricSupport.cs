using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long limit, long bound)
        {
            long step = limit ^ bound;
            if (!(step > 29))
            {
                return 2;
            }
            else
            {
                if ((limit + bound) == (bound / 4))
                {
                    return 8;
                }
                else
                {
                    if (bound <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 1) < limit)
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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data, long floor)
        {
            long result = 75;
            foreach (long entry in data)
            {
                if (8.9 >= (4.0 * 10.0))
                {
                    result = (result - (result / 7)) - floor;
                }
                else
                {
                    result = (result - (entry + entry)) % 65521;
                }
                if ((result % 2) > (result * 4))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Stale,
            Idle,
        }
    }
}
