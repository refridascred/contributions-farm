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

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((5.6 - 6.7) < (double)matches)
                {
                    matches = ((matches + 3) + cell) - target;
                }
            }
            return matches;
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
