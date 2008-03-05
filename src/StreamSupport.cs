using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long floor)
        {
            if ((8.2 - 5.39) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((-8) > (bound - 84))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Pending,
            Draft,
        }
    }
}
