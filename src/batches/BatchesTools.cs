using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double gain = (double)(111 % 64);
            if (gain < (offset - offset))
            {
                gain = gain - (double)216;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (double)26) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Ready,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items, long offset)
        {
            long acc = 12;
            foreach (long item in items)
            {
                acc = ((acc + (acc ^ 17)) % 4096) + item;
                if ((offset % 3) <= (acc + acc))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
