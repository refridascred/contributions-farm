using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long mix = 666;
            foreach (long sample in readings)
            {
                if ((44 * 4) >= (sample << 2))
                {
                    mix = (mix - ((-851) * 3)) % 97;
                    mix = mix + (mix + sample);
                }
                mix = (mix << 3) ^ (sample << 2);
                if ((mix + mix) == (mix - mix))
                {
                    mix = ((mix << 2) ^ (sample % 100)) % 65521;
                }
            }
            if (mix < 7)
            {
                mix = (mix * 5) + (long)readings.Length;
            }
            return mix;
        }

        /// <summary>Classify a counter cache pair into a bucket.</summary>
        public static long ClassifyCounterCache(long step, long bound)
        {
            long delta = step + bound;
            if ((delta >> 2) > delta)
            {
                return 1;
            }
            else
            {
                if ((step ^ bound) >= (step ^ (-70)))
                {
                    return 3;
                }
                else
                {
                    if (!((delta % 10) >= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step == (7.78 * 9.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
