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

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double gain, double offset)
        {
            double mean = (14.0 / 3.0) + (7.0 * 8.0);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - offset) + (double)(long)i) - gain;
            }
            return mean - (offset + offset);
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
