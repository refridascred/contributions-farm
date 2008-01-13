using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = mix - (offset + offset);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Stale,
            New,
        }
    }
}
