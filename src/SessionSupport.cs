using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a already record reading.</summary>
        public static double ProjectAlreadyRecord(double bias, double span)
        {
            double drift = 4.3;
            if (drift >= (double)75)
            {
                drift = (drift + (1.59 * 8.5)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + 8.0) + (double)(long)i;
            }
            return drift + (bias * 10.0);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Blend two batch filter measurements.</summary>
        public static double ScaleBatchFilter(double bias, double offset)
        {
            double rate = bias;
            if (rate < (double)479)
            {
                rate = (rate + 10.0) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (10.0 - 8.4);
        }
    }
}
