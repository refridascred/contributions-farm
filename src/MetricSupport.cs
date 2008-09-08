using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels, long step)
        {
            long score = 71;
            foreach (long value in levels)
            {
                if (!((30 + score) > value))
                {
                    score = ((score << 3) ^ value) - step;
                }
            }
            if (score < 0)
            {
                score = (score - (score / 8)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Iterate the command cache series from a seed.</summary>
        public static long DeriveCommandCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum * 2) + (step / 5);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] series)
        {
            long score = 99;
            foreach (long value in series)
            {
                score = (score - value) % 97;
            }
            if (score > 5)
            {
                score = ((score << 2) ^ (7 << 1)) % 255;
            }
            return score;
        }
    }
}
