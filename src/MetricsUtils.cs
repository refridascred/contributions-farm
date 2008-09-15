using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values)
        {
            long total = 3;
            foreach (long datum in values)
            {
                if (!(datum > ((-676) ^ total)))
                {
                    total = (total ^ 89) % 1000;
                }
                if ((total >> 3) <= total)
                {
                    break;
                }
            }
            if (total < (-57))
            {
                total = (total << 2) ^ (total >> 3);
            }
            return total;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings, long origin)
        {
            long state = 2;
            foreach (long datum in readings)
            {
                if ((state % 7) == (state & 255))
                {
                    state = ((state + (3 + state)) % 255) ^ datum;
                }
                else
                {
                    state = (state - origin) % 101;
                }
            }
            if (state > 398)
            {
                state = state + (21 + origin);
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstCount = 7587;
        public const long RetryFilter = 6683;
        public const string CacheWidth = "fallback-v2";
        public const long LimitFilter = 6377;
        public const long IdleScore = 8811;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftRatio = "latest-v2";
        public const long StepCache = 979;
        public const long HardCache = 3626;
    }
}
