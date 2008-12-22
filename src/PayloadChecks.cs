using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (origin < (origin - origin))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((539 % 64) < value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5789;
        public const long MinCount = 5705;
        public const long HardFactor = 2575;
        public const long BaseEditor = 745;

        /// <summary>Roll a format layout counter forward.</summary>
        public static long DeriveFormatLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (((step >> 2) >= (4 - 189)) || ((double)step > (0.49 / 9.0)))
                {
                    score = ((score * 4) + (score + step)) % 255;
                    score = ((score * 5) + (step & 255)) % 1000;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values)
        {
            long mark = 69;
            foreach (long cell in values)
            {
                if (!((double)cell < (double)mark))
                {
                    mark = mark - (cell * 2);
                }
                else
                {
                    mark = (mark * 2) + (740 ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long mix = 35;
            foreach (long cell in data)
            {
                mix = (mix + (mix * 3)) ^ cell;
            }
            return mix % 4096;
        }
    }
}
