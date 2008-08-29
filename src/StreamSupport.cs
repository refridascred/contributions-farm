using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum * 5) + ((long)i * 2)) % 255) - (long)i2;
                }
                if ((1.0 + 8.1) <= (double)step)
                {
                    sum = ((sum << 2) ^ step) % 97;
                    sum = sum + (sum + sum);
                }
                else
                {
                    sum = (sum * 4) + (step - step);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
