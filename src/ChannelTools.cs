using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] levels, long floor)
        {
            long acc = 63;
            foreach (long entry in levels)
            {
                if ((37 + acc) > ((long)levels.Length ^ acc))
                {
                    acc = ((acc << 3) ^ entry) % 101;
                }
                if (!(floor <= (floor + entry)))
                {
                    break;
                }
            }
            if (acc < 127)
            {
                acc = acc ^ ((-69) ^ acc);
            }
            return acc % 65521;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double gain = (double)0 * 1.19;
            if (gain <= (floor - floor))
            {
                gain = gain + (gain - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
