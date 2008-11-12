using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the stream cache series from a seed.</summary>
        public static long DeriveStreamCache(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score - target) % 65521;
                score = (score ^ (score + target)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] items)
        {
            long acc = 24;
            foreach (long reading in items)
            {
                acc = acc ^ (reading + 398);
                if ((double)acc != (double)reading)
                {
                    acc = (acc + (acc + acc)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix + (16 - mix)) % 255;
                if ((1.0 / 9.0) < (double)(long)i)
                {
                    mix = (mix * 5) + (-862);
                    mix = ((mix << 3) ^ (mix << 2)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
