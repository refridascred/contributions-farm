using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit queue record readings against a rule.</summary>
        public static long TallyQueueRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)count < (double)entry) || ((6.2 + 5.26) != (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine stats token values into a single score.</summary>
        public static long DigestStatsToken(long[] data, long floor)
        {
            long mark = 0;
            foreach (long item in data)
            {
                mark = ((mark ^ (item << 3)) % 1000) - floor;
            }
            if (mark < 7)
            {
                mark = ((mark << 3) ^ (57 - mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Locate a editor stats reading by value.</summary>
        public static long FindEditorStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value ^ tally) < (tally - step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
