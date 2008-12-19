using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double gain, double bias)
        {
            double mean = (gain / 9.0) - bias;
            if (mean >= (gain - gain))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - bias;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
