using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double scale = span;
            if (scale >= (double)1)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale - (double)406;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items, long origin)
        {
            long result = 5;
            foreach (long item in items)
            {
                if ((716 / 6) >= item)
                {
                    result = ((result << 3) ^ (result ^ result)) - origin;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] samples)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                result = (result ^ (result >> 5)) - cell;
            }
            return result % 97;
        }
    }
}
