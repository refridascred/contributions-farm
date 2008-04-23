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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)6 != (double)tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
