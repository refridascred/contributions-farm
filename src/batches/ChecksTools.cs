using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metrics channel entries that pass the check.</summary>
        public static long AuditMetricsChannelHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + matches) == (offset - offset))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long limit)
        {
            if ((floor - 43) < (373 - floor))
            {
                return 0;
            }
            else
            {
                if ((limit & 3) <= (5 - limit))
                {
                    return 6;
                }
                else
                {
                    if (limit > (floor + 375))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix << 2) ^ (offset + mix);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix + (mix ^ mix)) ^ (long)i2;
                }
                if ((-91) > ((long)i / 8))
                {
                    long bound = mix;
                    mix = (mix + (mix - bound)) % 97;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
