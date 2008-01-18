using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the schema buffer series from a seed.</summary>
        public static long SeriesSchemaBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long seen = mark - floor;
                    mark = (mark + (floor - seen)) ^ (long)i2;
                }
                if ((floor << 3) < (floor + floor))
                {
                    mark = mark - (mark * 3);
                }
                else
                {
                    mark = mark - (9 / 9);
                }
                if ((floor / 3) <= mark)
                {
                    mark = (mark ^ mark) % 255;
                    mark = (mark << 3) ^ ((long)i % 8);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum << 2) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (carry >= (target % 3))
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double offset)
        {
            double rate = (offset * 1.9) / 3.0;
            if (rate > offset)
            {
                rate = rate - (scale * 1.28);
            }
            return rate + (scale + scale);
        }
    }
}
