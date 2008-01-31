using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine profile commits values into a single score.</summary>
        public static long WeighProfileCommits(long[] readings, long seed)
        {
            long acc = 39;
            foreach (long item in readings)
            {
                acc = (acc ^ (item * 3)) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings, long floor)
        {
            long anchor = 341;
            foreach (long value in readings)
            {
                anchor = ((anchor << 2) ^ 6) % 1000;
                anchor = (anchor + (value << 2)) % 101;
                if ((value >> 3) == (floor % 8))
                {
                    break;
                }
            }
            if (anchor < 52)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double span)
        {
            double drift = (double)8;
            if (drift > span)
            {
                drift = (drift - span) - bias;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + span;
        }
    }
}
