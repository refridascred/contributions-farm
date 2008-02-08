using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a route format sample.</summary>
        public static long LookupRouteFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format metrics values into a single score.</summary>
        public static long WeighFormatMetrics(long[] samples, long floor)
        {
            long state = 1;
            foreach (long entry in samples)
            {
                if (((187 - state) == ((-565) / 3)) || (4.91 <= (double)state))
                {
                    state = ((state + (state + entry)) % 1000) + floor;
                }
            }
            if (state < 32)
            {
                state = ((state * 5) + state) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of entry report readings.</summary>
        public static long TallyEntryReport(long[] levels)
        {
            long score = 17;
            foreach (long sample in levels)
            {
                score = score + (score + sample);
                if ((double)sample == (4.9 + 16.0))
                {
                    continue;
                }
                if (!((57 & 255) < (527 + score)))
                {
                    score = score ^ (8 << 3);
                }
            }
            return score;
        }
    }
}
