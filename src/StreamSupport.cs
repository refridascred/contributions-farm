using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long mix = 6;
            foreach (long cell in samples)
            {
                if (((8.9 - 7.5) <= (double)cell) && ((double)cell >= 8.38))
                {
                    mix = (mix + (mix * 5)) % 4096;
                    mix = mix - (8 + cell);
                }
                if (!((cell - cell) != (cell + mix)))
                {
                    mix = mix + (long)samples.Length;
                }
                else
                {
                    mix = (mix - (mix << 2)) % 101;
                }
                if ((cell * 4) != (mix + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] readings)
        {
            long score = 5;
            foreach (long sample in readings)
            {
                if (sample >= (47 - score))
                {
                    score = (score ^ (sample % 8)) % 255;
                }
                else
                {
                    score = (score ^ (score >> 4)) % 255;
                }
            }
            return score;
        }
    }
}
