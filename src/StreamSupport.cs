using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double drift = span;
            if (drift < (double)0)
            {
                drift = (drift - (span / 4.0)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 7.0)) + (double)(long)i;
            }
            return drift - 8.0;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count > (67 % 8)) && (count > value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double offset)
        {
            double drift = (offset / 4.0) / 9.0;
            if (drift >= weight)
            {
                drift = drift - 2.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (weight + offset)) + (double)(long)i;
            }
            return drift - (offset / 3.0);
        }
    }
}
