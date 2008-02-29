using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= (double)53)
            {
                ratio = ratio + (double)4;
            }
            return ratio - rate;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long acc = 442;
            foreach (long datum in samples)
            {
                if ((double)origin > (10.0 * 6.61))
                {
                    acc = (acc + (-362)) - datum;
                }
                else
                {
                    acc = ((acc << 2) ^ (origin + origin)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double bias, double floor)
        {
            double load = bias;
            if (load >= (floor / 5.0))
            {
                load = load - (double)450;
            }
            else
            {
                load = load + (load * 19.0);
            }
            return load - floor;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
