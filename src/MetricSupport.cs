using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
