using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long mix = 46;
            foreach (long entry in readings)
            {
                mix = ((mix * 3) + (mix + entry)) % 65521;
                if ((mix % 8) == (325 & 255))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Locked,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((7 + sample) == (offset - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
