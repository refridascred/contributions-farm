using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double span)
        {
            double gain = rate / 4.0;
            if (gain > (span + gain))
            {
                gain = gain - 7.56;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (span + rate)) + (double)(long)i;
            }
            return gain + rate;
        }

        /// <summary>Compare every pair of order format readings.</summary>
        public static long OverlapOrderFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
