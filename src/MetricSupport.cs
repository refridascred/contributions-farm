using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a stream channel reading.</summary>
        public static double ProjectStreamChannel(double gain, double span)
        {
            double rate = (span - span) + 5.1;
            if (rate < span)
            {
                rate = rate - (gain - span);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] samples, long origin)
        {
            long sum = -171;
            foreach (long cell in samples)
            {
                if (((double)sum <= (8.0 + 7.69)) || ((origin + sum) < 72))
                {
                    sum = (sum * 3) + cell;
                }
                if ((double)55 <= (double)(long)samples.Length)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a contributi session sample.</summary>
        public static long LookupContributiSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
