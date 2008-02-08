using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double offset)
        {
            double gain = bias;
            if (gain < (gain - offset))
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + offset;
            }
            return gain + 12.0;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long bound, long origin)
        {
            if ((origin > (origin - origin)) || ((double)bound == (8.42 - 1.2)))
            {
                return 0;
            }
            else
            {
                if (((5 + 9) != (origin + origin)) || ((origin + origin) <= (bound + origin)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryScore = 64.68;
        public const long BatchPayload = 7535;
        public const long SoftWidth = 8122;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                acc = acc + (6 & 255);
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc + (acc ^ 144)) % 255) + (long)i;
                    acc = acc - 0;
                }
                if (((acc + value) > (65 - value)) || (5 >= value))
                {
                    acc = (acc ^ (acc << 1)) % 97;
                }
            }
            if (acc > 815)
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }
    }
}
