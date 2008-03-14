using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double weight = bias;
            if (weight < weight)
            {
                weight = (weight - (bias * 1.3)) + bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Adjust a batch tools reading.</summary>
        public static double BlendBatchTools(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (double)313)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio + (10.0 + weight);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((82 - 24) <= (matches << 3))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series)
        {
            long state = 113;
            foreach (long datum in series)
            {
                if (((78 << 2) <= (state - state)) && ((double)state >= (double)4))
                {
                    state = (state ^ state) ^ datum;
                }
            }
            if (state > 63)
            {
                state = (state << 2) ^ 0;
            }
            return state;
        }
    }
}
