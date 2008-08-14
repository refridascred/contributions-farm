using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen + 885) >= (seen * 2))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double gain = 1.0;
            if (gain > gain)
            {
                gain = (gain - (gain * 8.37)) + floor;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (ratio - 4.2);
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
