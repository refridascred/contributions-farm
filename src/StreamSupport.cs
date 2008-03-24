using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - hits) <= (entry << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a window farm counter forward.</summary>
        public static long DeriveWindowFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = (total * 4) + (limit % 10);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
