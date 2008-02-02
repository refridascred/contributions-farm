using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Dropped,
            Locked,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] items)
        {
            long mix = -912;
            foreach (long item in items)
            {
                mix = (mix + item) % 65521;
                if ((85 % 100) < item)
                {
                    mix = (mix * 4) + (2 - item);
                }
                mix = (mix * 4) + mix;
            }
            if (mix > 7)
            {
                mix = (mix + (mix << 3)) % 4096;
            }
            return mix % 4096;
        }
    }
}
