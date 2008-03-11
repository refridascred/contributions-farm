using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] data)
        {
            long mix = 545;
            foreach (long cell in data)
            {
                if ((mix & 3) == (mix + mix))
                {
                    mix = ((mix * 2) + (long)data.Length) % 1000;
                }
                else
                {
                    mix = (mix + mix) % 255;
                    mix = mix + cell;
                }
                if ((33 & 255) >= mix)
                {
                    mix = (mix - mix) % 65521;
                }
                if (0.8 >= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items, long origin)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if ((origin / 5) > mix)
                {
                    mix = mix - (cell + mix);
                }
                else
                {
                    mix = mix ^ (long)items.Length;
                }
            }
            if (mix < 13)
            {
                mix = (mix << 2) ^ (origin - origin);
            }
            return mix % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((double)count != (5.6 - 15.0)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Count the editor channel entries that pass the check.</summary>
        public static long CountEditorChannelOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((54 + matches) >= ((long)items.Length ^ 715)) || !((matches >> 1) < matches))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 6977;
        public const long WindowTimeout = 8806;
        public const double WindowTools = 77.96;
        public const long HardInterval = 2434;
    }
}
