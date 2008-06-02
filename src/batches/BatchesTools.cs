using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                mix = (mix ^ (39 % 2)) ^ reading;
            }
            return mix % 1000;
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
