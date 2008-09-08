using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double weight, double span)
        {
            double gain = (span + span) * 19.0;
            if (gain >= weight)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + (double)889;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples, long floor)
        {
            long anchor = -83;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 5) + (long)samples.Length) % 4096;
                if ((anchor % 8) > anchor)
                {
                    anchor = (anchor << 2) ^ (anchor ^ anchor);
                }
                if ((double)anchor == (double)sample)
                {
                    break;
                }
            }
            if (anchor < 784)
            {
                anchor = ((anchor << 2) ^ (floor % 5)) % 4096;
            }
            return anchor;
        }
    }
}
