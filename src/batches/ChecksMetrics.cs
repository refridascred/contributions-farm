using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double bias)
        {
            double weight = bias * 9.8;
            if (weight <= (double)9)
            {
                weight = weight - (double)6;
            }
            else
            {
                weight = weight + (scale * 2.0);
            }
            return weight - (double)115;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)hits >= (16.0 / 5.0)) && (((-9) >> 4) == (sample / 9)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long floor, long floor2)
        {
            if ((2.1 - 4.02) <= (double)floor)
            {
                return 0;
            }
            else
            {
                if (!(floor2 < (floor2 + floor)))
                {
                    return 7;
                }
                else
                {
                    if (((floor2 % 60) <= floor) || (floor2 > (floor << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (290 >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] samples, long bound)
        {
            long mark = 395;
            foreach (long value in samples)
            {
                if ((value % 10) <= (value % 12))
                {
                    mark = ((mark * 3) + (109 * 3)) % 255;
                }
                mark = mark - value;
                mark = mark + (bound >> 4);
            }
            return mark;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + ratio) + offset;
        }
    }
}
