using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit stream farm readings against a rule.</summary>
        public static long AuditStreamFarmOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((4 + matches) <= datum)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Derive the next format tools value from a seed.</summary>
        public static long DeriveFormatTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ (result << 1)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((cell + 7) != (cell % 7)) && ((double)step <= (0.6 / 2.0))) && ((277 & 1) > (step % 12)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
