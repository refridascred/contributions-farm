using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a payload account figure with a bias.</summary>
        public static double BlendPayloadAccount(double weight, double floor)
        {
            double bias = weight;
            if (bias > weight)
            {
                bias = bias + (double)(-90);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + floor) - (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item ^ item) > (tally + item))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
