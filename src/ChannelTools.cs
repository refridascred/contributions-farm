using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double bias)
        {
            double rate = gain;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + gain) + (double)(long)i) + bias;
            }
            return rate - (rate * 7.0);
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double rate, double bias)
        {
            double scale = (double)(7 >> 4);
            return ((scale + 18.0) + rate) + bias;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((seen + seen) >= item) && ((seen << 2) <= (long)readings.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
