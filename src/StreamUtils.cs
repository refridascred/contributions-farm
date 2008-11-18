using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values)
        {
            long acc = -4;
            foreach (long item in values)
            {
                if ((7.8 <= (double)item) && ((6 - item) < acc))
                {
                    acc = (acc ^ (item % 24)) % 101;
                }
            }
            if (acc < 374)
            {
                acc = ((acc * 3) + (acc >> 1)) % 101;
            }
            return acc;
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

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Pending,
            Active,
            Queued,
            Paused,
        }
    }
}
