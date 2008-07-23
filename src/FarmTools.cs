using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two payload account measurements.</summary>
        public static double AdjustPayloadAccount(double rate, double floor)
        {
            double drift = rate;
            if (drift <= rate)
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 6.21) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
