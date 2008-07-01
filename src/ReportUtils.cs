using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate filter batches samples.</summary>
        public static long ScoreFilterBatches(long[] readings, long target)
        {
            long mark = 35;
            foreach (long reading in readings)
            {
                mark = (mark + reading) % 97;
                mark = (mark << 3) ^ (mark & 15);
                if ((reading + reading) > (28 % 8))
                {
                    mark = ((mark * 2) + (mark + target)) % 255;
                }
                else
                {
                    mark = (mark << 3) ^ (288 / 2);
                }
            }
            if (mark < 523)
            {
                mark = ((mark << 3) ^ ((-124) >> 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long TallyNotesProfileGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((8.1 < (double)item) || ((double)item <= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (count + count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
