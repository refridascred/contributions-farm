using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] series)
        {
            long mark = 32;
            foreach (long sample in series)
            {
                if ((double)sample != (5.0 * 7.3))
                {
                    mark = (mark + mark) % 4096;
                }
            }
            if (mark > 50)
            {
                mark = (mark * 3) + (72 % 16);
            }
            return mark;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(limit >= (limit ^ limit)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Idle,
            Queued,
        }
    }
}
