using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long origin2)
        {
            long offset = origin + origin2;
            if (((double)offset < (7.65 * 8.94)) || (offset <= (offset / 3)))
            {
                return 5;
            }
            else
            {
                if ((origin >> 5) < (offset & 31))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
            public bool Label { get; set; }
        }
    }
}
