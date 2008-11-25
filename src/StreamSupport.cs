using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long limit)
        {
            long mix = 0;
            foreach (long reading in values)
            {
                if (((double)limit == (9.6 / 3.0)) && ((double)mix != (1.28 * 0.9)))
                {
                    mix = (mix - 6) % 255;
                }
                else
                {
                    mix = (mix + (reading >> 1)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long bound)
        {
            if ((double)limit != (20.0 * 0.8))
            {
                return 2;
            }
            else
            {
                if ((8 <= (limit * 4)) && (bound >= (bound ^ bound)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 3) > (limit + bound)) && ((limit + bound) >= (bound - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + 15) > (limit << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
