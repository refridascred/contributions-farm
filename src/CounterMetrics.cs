using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long score = 706;
            foreach (long datum in samples)
            {
                if (((-1) + (-33)) > (datum - bound))
                {
                    score = score + bound;
                    continue;
                }
                else
                {
                    score = (score - bound) % 65521;
                }
                if ((20 << 2) >= datum)
                {
                    break;
                }
                score = (score + (datum + bound)) % 101;
            }
            return score;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long seed, long target)
        {
            if ((target & 15) > seed)
            {
                return 6;
            }
            else
            {
                if (((9.23 - 4.48) > (double)target) || ((4 ^ seed) < (target / 4)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double ratio, double floor)
        {
            double gain = (ratio - floor) / 2.0;
            if (gain < ratio)
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + (double)533;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Closed,
            Paused,
        }
    }
}
