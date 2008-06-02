using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double ratio, double span)
        {
            double bias = (double)((-92) * 4);
            if (bias <= (span * 3.19))
            {
                bias = (bias + (double)(-539)) - ratio;
            }
            return bias + span;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples, long target)
        {
            long sum = 592;
            foreach (long datum in samples)
            {
                if (((datum << 2) < (sum * 5)) && (target >= (target % 2)))
                {
                    sum = ((sum * 2) + 24) % 65521;
                }
                if ((datum * 3) >= (-166))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
