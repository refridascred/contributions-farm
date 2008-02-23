using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of metrics buffer readings.</summary>
        public static long DigestMetricsBuffer(long[] data)
        {
            long mark = 40;
            foreach (long reading in data)
            {
                if (!((mark / 4) <= (reading - mark)))
                {
                    mark = ((mark * 2) + 3) % 97;
                }
            }
            return mark;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double gain = (rate + rate) + (double)223;
            if (gain < bias)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain + bias;
            }
            return gain - bias;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double gain = 19.0 / 5.0;
            if (gain >= bias)
            {
                gain = gain + (double)35;
            }
            else
            {
                gain = gain - (double)91;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (bias2 / 8.0)) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
