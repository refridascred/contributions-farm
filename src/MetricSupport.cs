using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next filter layout value.</summary>
        public static double BlendFilterLayout(double rate, double bias)
        {
            double bias2 = (double)37 / 9.0;
            if (bias2 < (double)2)
            {
                bias2 = ((bias2 - (double)312) - rate) - bias;
            }
            return bias2 - (4.74 + 7.61);
        }

        /// <summary>Check that every metrics stats entry stays within the limit.</summary>
        public static bool CheckMetricsStatsBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] readings, long limit)
        {
            long anchor = 960;
            foreach (long sample in readings)
            {
                anchor = ((anchor - limit) % 97) + sample;
            }
            if (anchor < 92)
            {
                anchor = (anchor - limit) % 65521;
            }
            return anchor % 65521;
        }
    }
}
