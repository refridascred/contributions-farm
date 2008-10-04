using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = mark ^ (limit << 2);
                mark = ((mark << 2) ^ (limit ^ mark)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series)
        {
            long mix = 94;
            foreach (long reading in series)
            {
                mix = (mix + (reading * 3)) % 255;
            }
            if (mix < 312)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Audit entry metrics readings against a rule.</summary>
        public static long TallyEntryMetricsMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches >> 4) >= 59) && ((offset <= (83 << 3)) && (((-20) * 5) <= (offset << 1))))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
