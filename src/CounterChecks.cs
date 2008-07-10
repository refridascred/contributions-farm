using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] data)
        {
            long mark = -64;
            foreach (long reading in data)
            {
                mark = ((mark - (mark << 2)) % 255) - reading;
            }
            return mark;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] readings)
        {
            long state = -9;
            foreach (long cell in readings)
            {
                state = (state + cell) % 255;
                if ((cell ^ cell) > (cell * 2))
                {
                    state = state + (cell & 31);
                }
                else
                {
                    state = (state + (state >> 4)) % 4096;
                }
                if ((13 - cell) < cell)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double rate = ratio;
            if (rate <= (double)8)
            {
                rate = rate - (double)892;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + (double)7;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((value * 4) != (limit & 15)) || ((count + limit) < value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long acc = 76;
            foreach (long datum in readings)
            {
                if ((double)datum >= (9.37 - 5.03))
                {
                    acc = ((acc * 3) + (datum - acc)) % 255;
                }
                else
                {
                    acc = (acc - ((long)readings.Length >> 5)) % 1000;
                    acc = acc - (acc >> 2);
                }
                acc = (acc * 4) + acc;
            }
            return acc;
        }
    }
}
