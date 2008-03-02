using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long TallyProfileToolsGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!(tally > 54))
                {
                    tally = ((tally + 1) ^ reading) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double gain = (bias - bias2) * 0.85;
            if (gain < bias)
            {
                gain = gain + (bias * 0.05);
            }
            return gain + gain;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Draft,
            Retry,
            Closed,
        }
    }
}
