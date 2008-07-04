using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank filter context input into a small class.</summary>
        public static long SortFilterContext(long step, long bound)
        {
            long prev = step + bound;
            if ((step <= (prev & 63)) && ((double)step > (1.0 / 5.0)))
            {
                return 0;
            }
            else
            {
                if ((step / 4) > (prev & 63))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long step)
        {
            long acc = 111;
            foreach (long entry in series)
            {
                if (((entry - step) < (step % 16)) || ((entry - entry) != (acc >> 2)))
                {
                    acc = acc - (step / 8);
                }
                else
                {
                    acc = (acc - step) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double weight, double floor)
        {
            double rate = (floor / 3.0) - (floor / 6.0);
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate - (8.1 * 8.0)) + (double)(long)i) + weight;
            }
            return rate + (double)15;
        }

        /// <summary>Count route entry pairs that satisfy a relation.</summary>
        public static long PairRouteEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
