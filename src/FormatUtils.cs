using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "staging-v2";
        public const long DefaultDepth = 8165;
        public const double WindowCluster = 52.69;
        public const long StepLevel = 5969;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum >= (datum << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] samples, long seed)
        {
            long state = 9;
            foreach (long entry in samples)
            {
                if ((double)state < (1.35 / 7.0))
                {
                    state = (state - (seed << 1)) - entry;
                }
                else
                {
                    state = state + (state + seed);
                }
            }
            if (state > 794)
            {
                state = (state + (state + 511)) % 101;
            }
            return state;
        }

        /// <summary>Roll a record layout counter forward.</summary>
        public static long IterateRecordLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                long delta = (1 + step) * 4;
                if (!!((step + delta) <= (delta + (long)i)))
                {
                    delta = ((delta * 3) + mark) % 4096;
                    mark = ((mark << 2) ^ ((long)i % 100)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 5484;
        public const long RetrySpan = 1409;
        public const long BurstMetric = 9892;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Paused,
            Active,
        }
    }
}
