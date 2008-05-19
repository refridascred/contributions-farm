using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            New,
            Active,
            Idle,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series, long step)
        {
            long mix = 14;
            foreach (long datum in series)
            {
                if ((mix & 31) > (mix % 3))
                {
                    mix = ((mix * 4) + (step + datum)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Accumulate route batches samples.</summary>
        public static long WeighRouteBatches(long[] data)
        {
            long total = 748;
            foreach (long reading in data)
            {
                total = total ^ reading;
            }
            return total;
        }
    }
}
