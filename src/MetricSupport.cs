using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((reading - step) < matches) || (reading <= (2 * 4)))
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

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double ratio, double floor)
        {
            double drift = floor / 6.0;
            if (drift <= (double)366)
            {
                drift = (drift - (double)661) + ratio;
            }
            else
            {
                drift = drift + (double)92;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (9.2 + floor)) + (double)(long)i;
            }
            return drift + (double)(-891);
        }
    }
}
