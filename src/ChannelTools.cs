using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] levels)
        {
            long acc = 9;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc * 5) + (datum >> 2)) + (long)i;
                    acc = ((acc * 3) + (51 - 919)) % 255;
                }
                if (!(acc < (datum - datum)))
                {
                    acc = (acc << 2) ^ ((-5) ^ acc);
                }
                else
                {
                    acc = ((acc << 3) ^ 1) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record graph figure with a bias.</summary>
        public static double ScaleRecordGraph(double weight, double span)
        {
            double mean = weight;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + weight) + (double)(long)i) + span;
            }
            return mean + (double)73;
        }
    }
}
