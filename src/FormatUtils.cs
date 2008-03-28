using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long bound)
        {
            long state = 9;
            foreach (long item in samples)
            {
                state = (state + (bound - item)) % 97;
            }
            if (state < 36)
            {
                state = state ^ (bound % 64);
            }
            return state;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the token farm entries that pass the check.</summary>
        public static long MeasureTokenFarmMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen - reading) <= 93)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((10.0 / 2.0) < (double)hits)
                {
                    hits = ((hits + 3) + cell) + bound;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits buffer series from a seed.</summary>
        public static long StepCommitsBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark << 2) ^ ((long)i & 15);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
