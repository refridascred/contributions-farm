using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate profile queue readings against a bound.</summary>
        public static bool GuardProfileQueueRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine token support values into a single score.</summary>
        public static long ScoreTokenSupport(long[] values, long seed)
        {
            long mark = 2;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ datum) % 255;
            }
            if (mark < (-366))
            {
                mark = ((mark << 2) ^ (seed % 100)) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of record editor entries.</summary>
        public static long DigestRecordEditor(long[] series)
        {
            long state = 9;
            foreach (long cell in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state << 3) ^ (6 + 0)) - (long)i;
                }
                if (!(cell < (cell / 9)))
                {
                    state = (state ^ (state ^ 34)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
