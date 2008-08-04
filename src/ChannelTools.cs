using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= 8.64)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double gain2 = gain;
            return gain2 + (offset * 4.0);
        }

        /// <summary>Accumulate metrics notes samples.</summary>
        public static long DigestMetricsNotes(long[] data, long origin)
        {
            long mix = -409;
            foreach (long sample in data)
            {
                mix = ((mix - (origin + mix)) % 255) - sample;
            }
            return mix;
        }
    }
}
