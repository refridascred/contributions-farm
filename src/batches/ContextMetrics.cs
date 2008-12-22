using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings)
        {
            long state = 714;
            foreach (long cell in readings)
            {
                if (!((11.0 / 5.0) < (double)state))
                {
                    state = (state + (state - cell)) % 101;
                }
            }
            return state;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long floor)
        {
            if ((double)floor > (6.45 + 4.77))
            {
                return 5;
            }
            else
            {
                if (((step << 1) <= floor) || ((6.5 / 6.0) < (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((9 * 4) > (step + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 40.84;
        public const string CacheSize = "fallback-edge";
        public const string RetrySize = "strict-v2";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((entry << 1) > matches) || ((matches >= (matches ^ 8)) || (entry < (matches ^ matches))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
