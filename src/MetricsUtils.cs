using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a editor already counter forward.</summary>
        public static long IterateEditorAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                if (((step + 5) < 99) && ((step * 3) > (carry & 1)))
                {
                    continue;
                }
                carry = carry - step;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 2) + step) + (long)i2;
                    carry = ((carry << 2) ^ (0 << 3)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (6.0 + 17.0))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels, long limit)
        {
            long total = 16;
            foreach (long entry in levels)
            {
                total = ((total * 5) + (total + total)) - limit;
                total = (total + (entry & 7)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches <= (datum + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
