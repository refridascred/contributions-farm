using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double gain, double span)
        {
            double mean = gain;
            if (mean < span)
            {
                mean = mean - (gain * 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - 6.2;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item & 1) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
