using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values, long step)
        {
            long mark = 583;
            foreach (long sample in values)
            {
                mark = ((((mark << 3) ^ (3 % 97)) % 255) ^ sample) + step;
            }
            return mark;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double floor)
        {
            double load = rate;
            if (load >= (floor + rate))
            {
                load = load + load;
            }
            return load - (13.0 * 3.8);
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            New,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(datum <= (seen & 127)))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((19.0 / 6.0) == (double)seen))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
