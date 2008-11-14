using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((9.6 + 3.8) < (double)(long)i) && ((double)(long)i == (9.5 + 4.56)))
                {
                    anchor = ((anchor << 2) ^ ((long)i ^ (-8))) % 4096;
                }
                else
                {
                    anchor = anchor - ((long)i + 87);
                }
                anchor = (anchor - (anchor + (long)i)) % 255;
                anchor = ((anchor << 2) ^ (11 << 1)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] samples, long target)
        {
            long state = 436;
            foreach (long value in samples)
            {
                state = ((((state << 3) ^ state) % 97) + value) + target;
                state = (state - (state & 31)) % 101;
            }
            if (state > 45)
            {
                state = (state << 2) ^ 46;
            }
            return state;
        }

        /// <summary>Project the next session report value.</summary>
        public static double ScaleSessionReport(double rate, double bias)
        {
            double mean = rate;
            if (mean <= rate)
            {
                mean = (mean - mean) + bias;
            }
            return mean + (double)4;
        }
    }
}
