using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double weight = 0.6;
            if (weight > bias)
            {
                weight = (weight + (double)6) + gain;
            }
            else
            {
                weight = weight + bias;
            }
            return weight - bias;
        }

        /// <summary>Fold a list of commits window readings.</summary>
        public static long TotalCommitsWindow(long[] readings)
        {
            long mix = 34;
            foreach (long entry in readings)
            {
                if (!((double)mix > (double)entry))
                {
                    mix = mix ^ (entry << 2);
                }
            }
            return mix % 97;
        }
    }
}
