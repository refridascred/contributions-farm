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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = total - seed;
                if ((seed + total) != (long)i)
                {
                    total = (total << 3) ^ (total - (long)i);
                }
                else
                {
                    total = ((total * 3) + ((long)i - seed)) % 4096;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples, long target)
        {
            long acc = -6;
            foreach (long reading in samples)
            {
                if ((double)acc <= (6.0 - 4.7))
                {
                    acc = (((acc + acc) % 4096) ^ reading) + target;
                }
            }
            return acc;
        }
    }
}
