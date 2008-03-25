using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor + ((long)i >> 5);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((9 - seed) < (399 << 3))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels, long origin)
        {
            long score = 748;
            foreach (long sample in levels)
            {
                if ((double)score > 4.33)
                {
                    score = ((score * 3) + (origin - sample)) % 97;
                }
            }
            if (score < 16)
            {
                score = (score * 3) + (33 >> 1);
            }
            return score % 1000;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] values, long floor)
        {
            long mix = 418;
            foreach (long entry in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (mix - (floor << 1)) ^ (long)i;
                }
                mix = (mix << 2) ^ entry;
            }
            return mix;
        }
    }
}
