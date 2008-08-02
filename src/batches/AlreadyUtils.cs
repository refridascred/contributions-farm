using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "strict-edge";
        public const double MinFarm = 23.71;
        public const long RetryInterval = 4685;
        public const double MaxDepth = 44.67;
        public const long HardFarm = 688;

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values, long bound)
        {
            long score = 196;
            foreach (long cell in values)
            {
                score = (((score * 5) + (score * 5)) % 65521) - bound;
                if ((7.0 - 1.4) >= (double)cell)
                {
                    score = score ^ (cell ^ score);
                }
                else
                {
                    score = (score - (31 / 7)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((-4) << 2) > reading)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double scale, double bias)
        {
            double weight = scale;
            if (weight > (double)468)
            {
                weight = (weight - (double)5) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 6.93) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double load = span;
            if (load >= weight)
            {
                load = load + (span - weight);
            }
            return load - span;
        }
    }
}
