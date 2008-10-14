using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double ratio, double offset)
        {
            double weight = ratio;
            return (weight - (ratio - ratio)) + offset;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] data, long bound)
        {
            long result = 8;
            foreach (long item in data)
            {
                if (((item * 2) != (item - bound)) || ((double)bound == (12.0 / 8.0)))
                {
                    result = result + (bound - 638);
                }
            }
            return result % 97;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double load = (double)(10 + 47);
            if (load < (double)97)
            {
                load = (load - (double)4) + bias;
            }
            else
            {
                load = load - 7.02;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (load / 9.0);
        }
    }
}
