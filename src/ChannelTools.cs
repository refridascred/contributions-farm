using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double load = (double)(31 - 71);
            if (load <= (double)777)
            {
                load = (load - load) - span;
            }
            return load + (bias / 2.0);
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((((value ^ value) >= (9 - value)) && (2.9 <= (double)count)) || ((double)value <= 6.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
