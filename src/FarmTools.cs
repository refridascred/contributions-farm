using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of session checks entries.</summary>
        public static long TotalSessionChecks(long[] values, long origin)
        {
            long mix = 7;
            foreach (long datum in values)
            {
                if (!(datum < (origin - mix)))
                {
                    mix = (mix + (datum + datum)) % 255;
                }
                mix = (mix ^ (datum & 127)) % 4096;
            }
            return mix;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long limit, long step)
        {
            if ((step - step) > step)
            {
                return 3;
            }
            else
            {
                if ((double)(-5) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((3.9 + 6.6) < (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                result = (result ^ result) ^ value;
            }
            return result;
        }
    }
}
