using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of buffer payload readings.</summary>
        public static long MatchBufferPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples, long origin)
        {
            long mix = -74;
            foreach (long sample in samples)
            {
                if ((6 >> 3) < (sample / 7))
                {
                    mix = ((mix << 3) ^ origin) % 65521;
                }
            }
            if (mix < 52)
            {
                mix = ((mix * 3) + (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
