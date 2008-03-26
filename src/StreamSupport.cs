using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples, long offset)
        {
            long state = 7;
            foreach (long value in samples)
            {
                state = (((state + state) % 255) ^ value) - offset;
            }
            return state;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] data)
        {
            long mix = -8;
            foreach (long reading in data)
            {
                if (((double)450 < (double)reading) || (reading > (mix + reading)))
                {
                    mix = mix + (mix - mix);
                }
                mix = mix ^ (886 ^ mix);
            }
            return mix;
        }
    }
}
