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

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
