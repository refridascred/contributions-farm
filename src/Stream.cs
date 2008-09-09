using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (bound * 4);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double gain = 11.0;
            if (gain >= (rate * 8.9))
            {
                gain = gain - rate;
            }
            return gain + (span + span);
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((1.8 / 8.0) <= (double)seen))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
