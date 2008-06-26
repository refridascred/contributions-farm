using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score ^ (limit + score)) % 101) ^ (long)i2;
                    score = score - (score - limit);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a cluster commits reading.</summary>
        public static double AdjustClusterCommits(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= 1.2)
            {
                ratio = (ratio + (ratio / 8.0)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (3.41 - ratio)) - (double)(long)i;
            }
            return ratio - (9.8 * 2.2);
        }

        /// <summary>Digest a series of batch entry entries.</summary>
        public static long DigestBatchEntry(long[] levels, long step)
        {
            long mark = 82;
            foreach (long entry in levels)
            {
                mark = (((mark << 3) ^ (step & 15)) % 101) - entry;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of contributi stream entries.</summary>
        public static long ScoreContributiStream(long[] samples, long offset)
        {
            long acc = 4;
            foreach (long reading in samples)
            {
                if ((reading - offset) != (acc / 4))
                {
                    acc = (acc + (acc - reading)) % 101;
                }
            }
            return acc;
        }
    }
}
