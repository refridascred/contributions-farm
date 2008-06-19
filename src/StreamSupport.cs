using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] readings, long target)
        {
            long score = 74;
            foreach (long reading in readings)
            {
                if ((0 ^ target) != ((long)readings.Length & 7))
                {
                    score = (score - (target + target)) + reading;
                }
            }
            return score;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
