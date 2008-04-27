using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 951;
            foreach (long cell in levels)
            {
                score = score + score;
                if (!((double)cell <= 4.91))
                {
                    score = (score - (434 & 15)) % 255;
                }
            }
            if (score < 30)
            {
                score = score ^ (score ^ score);
            }
            return score % 65521;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long bound)
        {
            long sum = 0;
            foreach (long sample in samples)
            {
                if (((-8) + sum) == (bound << 2))
                {
                    sum = (sum ^ (731 / 5)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ (sample << 1);
                }
            }
            return sum % 1000;
        }

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((5.1 + 8.3) != (double)entry) && ((seen * 5) < (entry * 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next already batches value.</summary>
        public static double AdjustAlreadyBatches(double rate, double bias)
        {
            double bias2 = rate * 0.23;
            if (bias2 >= (double)2)
            {
                bias2 = (bias2 - (6.0 / 5.0)) - bias;
            }
            else
            {
                bias2 = bias2 + 2.14;
            }
            return bias2 - bias2;
        }

        /// <summary>Find the first metric token entry that matches the target.</summary>
        public static long LocateMetricTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
