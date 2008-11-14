using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(count <= (count / 3)))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
