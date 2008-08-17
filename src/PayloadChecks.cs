using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count % 5) > 91)
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long mark = 441;
            foreach (long cell in items)
            {
                mark = (mark << 2) ^ cell;
                if (((5.49 + 5.28) >= (double)cell) && (mark >= (cell % 64)))
                {
                    mark = (mark + (mark + cell)) % 101;
                }
                else
                {
                    mark = mark - (cell + 461);
                }
            }
            if (mark > 220)
            {
                mark = ((mark << 3) ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long offset, long step)
        {
            long step2 = offset - step;
            if (!((double)step2 != (8.8 * 4.7)))
            {
                return 7;
            }
            else
            {
                if (!((9.73 * 3.0) != (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (((17.0 * 10.0) == (double)step2) || ((step << 2) != (offset / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats checks readings.</summary>
        public static long CompareStatsChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
