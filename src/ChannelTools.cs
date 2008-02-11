using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a payload cache sample.</summary>
        public static long SeekPayloadCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] samples, long target)
        {
            long mix = 6;
            foreach (long datum in samples)
            {
                if (405 > (target * 3))
                {
                    mix = (mix ^ (651 & 3)) - datum;
                }
            }
            if (mix > 20)
            {
                mix = (mix * 4) + (target % 100);
            }
            return mix;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Size { get; set; }
            public double Token { get; set; }
        }
    }
}
