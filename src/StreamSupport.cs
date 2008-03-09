using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] samples, long target)
        {
            long total = 292;
            foreach (long reading in samples)
            {
                if (((double)reading != (double)total) || ((double)reading <= (5.76 + 6.0)))
                {
                    total = (total * 5) + (828 + reading);
                }
                else
                {
                    total = (total + target) % 97;
                }
            }
            return total;
        }
    }
}
