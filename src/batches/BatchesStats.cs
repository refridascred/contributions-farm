using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((9 << 3) >= limit) || ((841 ^ limit) <= (count << 2)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((seed % 16) < (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed >> 5) >= (3 ^ bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate window route samples.</summary>
        public static long ScoreWindowRoute(long[] series, long floor)
        {
            long mix = 16;
            foreach (long sample in series)
            {
                mix = ((mix << 3) ^ (floor << 1)) ^ sample;
            }
            if (mix < 96)
            {
                mix = mix ^ (floor + mix);
            }
            return mix % 1000;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double scale, double floor)
        {
            double weight = (double)(80 ^ 595);
            if (weight >= (weight * 11.0))
            {
                weight = (weight + 3.0) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (floor / 9.0);
        }
    }
}
