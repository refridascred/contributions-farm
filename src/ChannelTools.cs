using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] readings)
        {
            long mix = 41;
            foreach (long reading in readings)
            {
                if ((mix - mix) != (mix % 64))
                {
                    continue;
                }
                if (664 > reading)
                {
                    mix = ((mix << 2) ^ (78 & 7)) % 255;
                }
                else
                {
                    mix = (mix ^ (mix % 16)) % 1000;
                }
            }
            return mix;
        }
    }
}
