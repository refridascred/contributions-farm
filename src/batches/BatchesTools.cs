using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double weight = floor - (double)330;
            if (weight < (gain - weight))
            {
                weight = weight - (20.0 + floor);
            }
            return weight + weight;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] readings, long origin)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                if ((acc >= (701 - datum)) && ((acc ^ origin) == (acc / 9)))
                {
                    acc = ((acc << 2) ^ datum) % 65521;
                }
                else
                {
                    acc = acc + ((long)readings.Length + datum);
                }
            }
            if (acc > 1)
            {
                acc = acc ^ (acc / 5);
            }
            return acc % 4096;
        }

        /// <summary>Accumulate channel report samples.</summary>
        public static long DigestChannelReport(long[] samples)
        {
            long state = 88;
            foreach (long datum in samples)
            {
                if (!((1 ^ state) < (92 * 4)))
                {
                    state = ((state * 3) + (0 * 2)) ^ datum;
                }
            }
            return state;
        }
    }
}
