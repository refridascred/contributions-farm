using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 7676;
        public const long BatchRatio = 4618;
        public const long IdlePayload = 9297;
        public const double IdleScore = 7.17;
        public const double BurstWidth = 40.13;

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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((limit << 2) > reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
