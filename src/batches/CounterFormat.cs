using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally > 3.88)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch already entry stays within the limit.</summary>
        public static bool CheckBatchAlreadyRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double weight = gain;
            if (weight >= (double)827)
            {
                weight = (weight + (double)108) - span;
            }
            else
            {
                weight = weight - (double)(-123);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (8.5 / 9.0)) - (double)(long)i;
            }
            return weight - gain;
        }
    }
}
