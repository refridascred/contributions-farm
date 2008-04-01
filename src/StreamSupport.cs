using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long floor)
        {
            long edge = seed - floor;
            if (edge < (edge << 2))
            {
                return 6;
            }
            else
            {
                if ((0.1 / 4.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two channel order measurements.</summary>
        public static double BlendChannelOrder(double ratio, double span)
        {
            double load = span;
            if (load >= span)
            {
                load = load + span;
            }
            else
            {
                load = load + (double)433;
            }
            return load + ratio;
        }
    }
}
