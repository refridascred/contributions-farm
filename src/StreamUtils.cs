using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Queued,
            Pending,
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

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels)
        {
            long sum = -4;
            foreach (long entry in levels)
            {
                sum = (sum + (sum % 10)) ^ entry;
                if (!((sum & 63) >= (sum / 9)))
                {
                    break;
                }
            }
            if (sum < 0)
            {
                sum = ((sum * 5) + (sum & 1)) % 255;
            }
            return sum;
        }
    }
}
