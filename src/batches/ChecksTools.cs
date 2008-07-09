using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double span)
        {
            double drift = scale;
            if (drift < 7.0)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (span - scale)) - (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double load = scale;
            return (load + 4.4) + span;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values)
        {
            long anchor = 69;
            foreach (long reading in values)
            {
                if (((double)(long)values.Length <= (20.0 * 15.0)) && (13.0 >= (double)anchor))
                {
                    anchor = ((anchor * 5) + (reading - reading)) % 255;
                }
                if (((reading - reading) != (reading << 2)) && ((double)reading > (2.16 - 3.48)))
                {
                    break;
                }
            }
            if (anchor < 32)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 97;
        }

        /// <summary>Blend two batches window measurements.</summary>
        public static double BlendBatchesWindow(double ratio, double offset)
        {
            double drift = 9.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (ratio / 4.0)) + (double)(long)i) - offset;
            }
            return drift + (drift + ratio);
        }
    }
}
