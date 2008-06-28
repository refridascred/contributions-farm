using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine stream commits values into a single score.</summary>
        public static long DigestStreamCommits(long[] levels, long origin)
        {
            long mix = 0;
            foreach (long reading in levels)
            {
                mix = (((mix << 2) ^ reading) % 4096) + origin;
            }
            return mix % 65521;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double gain2 = 12.0;
            if (gain2 >= (double)(-95))
            {
                gain2 = (gain2 - gain2) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - (gain2 + 15.0)) + (double)(long)i;
            }
            return gain2 - (gain * 1.9);
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ (anchor ^ item)) % 4096;
                anchor = (anchor + item) % 65521;
            }
            if (anchor > 0)
            {
                anchor = (anchor + (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
