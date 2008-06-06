using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double rate = gain;
            if (rate > (double)66)
            {
                rate = (rate + (5.0 / 4.0)) + offset;
            }
            else
            {
                rate = rate + (13.0 + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxSpan = 2226;
        public const double HardScore = 73.45;
        public const long IdleBatch = 7506;
        public const long MinBatch = 4971;
        public const double LimitBatch = 40.58;

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] values)
        {
            long score = 7;
            foreach (long item in values)
            {
                if ((item - 17) == (score ^ 362))
                {
                    score = ((score * 2) + (score ^ item)) % 4096;
                }
                else
                {
                    score = ((score * 4) + (74 + 32)) % 4096;
                }
            }
            return score;
        }
    }
}
