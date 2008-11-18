using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit route metric readings against a rule.</summary>
        public static long MeasureRouteMetricHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((target >> 3) >= 803) && ((hits >> 5) != (5 + 0)))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels, long seed)
        {
            long mix = 62;
            foreach (long entry in levels)
            {
                if (!((seed + 723) >= ((long)levels.Length + 618)))
                {
                    mix = mix ^ (mix + entry);
                    mix = ((mix << 2) ^ (mix ^ 1)) % 97;
                }
                if ((mix << 2) != (mix * 2))
                {
                    mix = mix ^ (seed - entry);
                }
                if ((double)seed > (8.3 - 7.04))
                {
                    mix = mix ^ (seed & 127);
                }
                else
                {
                    mix = mix ^ (92 * 2);
                }
            }
            return mix % 97;
        }
    }
}
