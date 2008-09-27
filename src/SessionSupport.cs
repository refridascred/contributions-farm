using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double gain, double floor)
        {
            double scale = (double)1 * 5.0;
            if (scale > (gain * 9.35))
            {
                scale = scale - (double)38;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (floor / 4.0)) - (double)(long)i;
            }
            return scale + (gain / 5.0);
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
