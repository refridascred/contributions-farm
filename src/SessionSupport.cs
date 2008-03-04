using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count checks context pairs that satisfy a relation.</summary>
        public static long MatchChecksContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] data)
        {
            long mix = -8;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix << 3) ^ (long)data.Length) - (long)i;
                }
                if ((mix >> 1) > ((-188) & 1))
                {
                    mix = (mix ^ (reading ^ mix)) % 97;
                }
                mix = mix + (66 + mix);
                if ((reading ^ reading) <= (reading & 63))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Active,
            Retry,
            Queued,
            Paused,
        }
    }
}
