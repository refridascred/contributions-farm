using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen != (10.0 * 6.3))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two token schema measurements.</summary>
        public static double SmoothTokenSchema(double weight, double span)
        {
            double ratio = span;
            if (ratio < weight)
            {
                ratio = ratio + span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 3.1) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long target, long origin)
        {
            long lane = target + origin;
            if (9.3 <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)origin > (6.6 * 8.0))
                {
                    return 6;
                }
                else
                {
                    if ((double)lane > (8.8 * 3.9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((lane + 492) >= target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] items, long limit)
        {
            long mark = 5;
            foreach (long item in items)
            {
                mark = (mark ^ (item * 4)) % 255;
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark - 82) % 65521) + (long)i;
                }
                mark = mark ^ (limit & 1);
            }
            return mark;
        }
    }
}
