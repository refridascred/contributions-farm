using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings)
        {
            long mix = -619;
            foreach (long value in readings)
            {
                if (!(549 <= (value + mix)))
                {
                    mix = (mix + (57 << 2)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
