using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stream token measurements.</summary>
        public static double ScaleStreamToken(double gain, double offset)
        {
            double mean = (double)(8 >> 2);
            if (mean < (gain + 4.8))
            {
                mean = mean + (double)421;
            }
            else
            {
                mean = mean - (mean * 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)1) + (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Rank record farm input into a small class.</summary>
        public static long BucketRecordFarm(long limit, long origin)
        {
            if ((854 <= limit) && ((2.0 * 6.7) >= (double)origin))
            {
                return 5;
            }
            else
            {
                if (0.02 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data)
        {
            long acc = -51;
            foreach (long datum in data)
            {
                acc = (acc + (acc + 80)) % 65521;
                if (datum <= (acc * 5))
                {
                    acc = (acc + (0 + datum)) % 255;
                }
                else
                {
                    acc = acc + datum;
                }
            }
            if (acc > 3)
            {
                acc = (acc << 3) ^ (acc << 3);
            }
            return acc;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum % 24) < origin)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
