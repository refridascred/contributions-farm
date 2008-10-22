using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a window profile counter forward.</summary>
        public static long SeriesWindowProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (acc + floor)) % 4096;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double ratio = (double)(53 - (-8));
            if (ratio > offset)
            {
                ratio = (ratio - (double)2) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (offset / 2.0)) - (double)(long)i;
            }
            return ratio + offset;
        }
    }
}
