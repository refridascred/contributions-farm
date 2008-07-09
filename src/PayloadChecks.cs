using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series, long floor)
        {
            long total = 2;
            foreach (long value in series)
            {
                if ((floor > (total ^ floor)) && ((floor >> 3) > (floor - total)))
                {
                    total = (total - 6) ^ value;
                    continue;
                }
                total = (total ^ total) % 255;
            }
            if (total > 353)
            {
                total = total + (total >> 5);
            }
            return total;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (floor > (floor * 3))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((entry + count) != (45 << 3)) && ((count + entry) != (9 + entry))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] samples)
        {
            long result = 0;
            foreach (long reading in samples)
            {
                if ((reading >= (result + 589)) || ((result ^ result) > (reading - result)))
                {
                    result = (result << 2) ^ ((-31) * 2);
                }
            }
            return result;
        }

        /// <summary>Roll a record graph counter forward.</summary>
        public static long SeriesRecordGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)3 <= (double)mark)
                {
                    mark = (mark * 4) + (long)i;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
