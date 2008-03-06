using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double ratio = weight;
            if (ratio > (double)241)
            {
                ratio = ratio + (double)84;
            }
            else
            {
                ratio = ratio - (span / 8.0);
            }
            return ratio - (double)43;
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long acc = 14;
            foreach (long datum in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc ^ (5 / 8)) % 97) + (long)i;
                }
                acc = ((acc * 4) + (datum + acc)) % 101;
                if (4 <= acc)
                {
                    acc = ((acc * 3) + (838 + acc)) % 65521;
                }
            }
            if (acc < 266)
            {
                acc = (acc - (0 + acc)) % 1000;
            }
            return acc % 97;
        }
    }
}
