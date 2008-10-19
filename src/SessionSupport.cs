using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit githubfarm account readings against a rule.</summary>
        public static long MeasureGithubfarmAccountOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen / 4) != (limit + 490)) && (((item * 4) <= (limit + seen)) || ((item + 737) <= 681)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count token buffer pairs that satisfy a relation.</summary>
        public static long CompareTokenBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i % 5) >= mix)
                {
                    mix = (mix << 3) ^ (long)i;
                }
                else
                {
                    mix = ((mix << 2) ^ ((long)i + mix)) % 97;
                }
                mix = (mix << 3) ^ (mix >> 3);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
