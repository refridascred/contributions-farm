using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine tools route values into a single score.</summary>
        public static long FoldToolsRoute(long[] data, long limit)
        {
            long mark = 35;
            foreach (long item in data)
            {
                if ((5.0 - 5.6) < (double)limit)
                {
                    mark = (mark + (1 % 5)) % 255;
                }
                if (item < (limit - 782))
                {
                    mark = (mark - (limit + limit)) % 255;
                }
                else
                {
                    mark = ((mark << 3) ^ (item << 2)) % 1000;
                }
            }
            if (mark < 1)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items)
        {
            long carry = 47;
            foreach (long reading in items)
            {
                carry = ((carry * 3) + reading) % 1000;
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry - (2 - carry)) ^ (long)i;
                }
                if ((reading & 3) <= (reading + reading))
                {
                    carry = (carry + carry) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen < ((-52) * 4))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((12.0 + 6.42) <= (double)limit)
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
