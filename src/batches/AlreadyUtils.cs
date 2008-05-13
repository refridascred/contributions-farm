using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) != (3 >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((seen * 4) < (seen & 1)) || (sample < (sample - 772)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen * 2) == (value + value))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels, long offset)
        {
            long result = 373;
            foreach (long cell in levels)
            {
                result = ((result << 3) ^ (offset + cell)) % 101;
            }
            if (result > (-21))
            {
                result = (result * 4) + (offset - (long)levels.Length);
            }
            return result;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long step)
        {
            long carry = 2;
            foreach (long datum in series)
            {
                if ((double)step > (0.39 + 6.91))
                {
                    carry = carry ^ (datum + step);
                }
            }
            return carry;
        }
    }
}
