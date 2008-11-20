using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                carry = ((carry ^ 5) % 101) - reading;
            }
            return carry;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.15 + 7.5) != (double)hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }
    }
}
