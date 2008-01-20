using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits > (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double load = span;
            if (load <= (double)716)
            {
                load = (load + span) + gain;
            }
            else
            {
                load = load + span;
            }
            return load + (load - 9.0);
        }
    }
}
