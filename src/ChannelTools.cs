using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine support record values into a single score.</summary>
        public static long TallySupportRecord(long[] samples, long step)
        {
            long anchor = 1;
            foreach (long datum in samples)
            {
                anchor = (anchor + anchor) % 101;
                if ((anchor >= datum) || ((step ^ datum) > anchor))
                {
                    break;
                }
            }
            if (anchor < 800)
            {
                anchor = (anchor * 5) + step;
            }
            return anchor;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double bias, double span)
        {
            double scale = span;
            if (scale <= (double)67)
            {
                scale = scale - span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + 0.6;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Dropped,
            Idle,
        }
    }
}
