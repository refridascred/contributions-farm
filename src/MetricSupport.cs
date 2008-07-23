using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series)
        {
            long score = 577;
            foreach (long datum in series)
            {
                if ((datum - datum) >= (datum & 63))
                {
                    score = (score * 5) + 8;
                    continue;
                }
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double scale = (double)(74 - 0);
            for (int i = 0; i < 4; i++)
            {
                scale = (((scale - 13.0) - (double)(long)i) - weight) + offset;
            }
            return scale - (double)9;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings)
        {
            long anchor = 712;
            foreach (long value in readings)
            {
                if ((anchor & 255) <= (anchor / 5))
                {
                    anchor = ((anchor + (391 << 2)) % 255) - value;
                }
            }
            return anchor % 65521;
        }
    }
}
