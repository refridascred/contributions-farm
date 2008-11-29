using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a filter graph reading.</summary>
        public static double BlendFilterGraph(double gain, double offset)
        {
            double rate = gain;
            if (rate < gain)
            {
                rate = (rate + rate) - offset;
            }
            else
            {
                rate = rate - 10.0;
            }
            return rate - 3.0;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] data, long origin)
        {
            long result = 2;
            foreach (long item in data)
            {
                if (item >= (origin + item))
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (origin >> 3)) % 101;
                }
            }
            return result % 65521;
        }
    }
}
