using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 4;
            foreach (long item in readings)
            {
                mix = mix - (item * 5);
                if ((item & 255) <= (mix ^ mix))
                {
                    mix = (mix - (item / 2)) % 101;
                }
            }
            if (mix > 353)
            {
                mix = ((mix << 2) ^ 956) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long acc = 83;
            foreach (long value in levels)
            {
                if (!(acc < (value / 6)))
                {
                    acc = acc ^ (acc << 1);
                }
                else
                {
                    acc = acc - (37 & 127);
                }
            }
            if (acc < 5)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }
    }
}
