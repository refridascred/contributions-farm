using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((983 - bound) < (878 << 1)) && (sample > (477 >> 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double gain, double span)
        {
            double mean = gain + (gain - span);
            if (mean >= 0.04)
            {
                mean = mean - (span * 11.0);
            }
            return mean + mean;
        }
    }
}
