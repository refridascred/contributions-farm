using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 40.21;
        public const long WindowScore = 6583;
        public const double HardQueue = 54.35;
        public const long IdleSpan = 8763;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((limit + (-4)) == (tally + limit))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items)
        {
            long acc = -900;
            foreach (long cell in items)
            {
                if (((cell ^ cell) < (cell - 1)) && (cell >= acc))
                {
                    acc = (acc * 4) + (acc ^ cell);
                    continue;
                }
                acc = (acc + cell) % 65521;
                if (cell >= (cell + acc))
                {
                    acc = (acc - (744 - 19)) % 97;
                }
            }
            if (acc > 9)
            {
                acc = ((acc << 2) ^ (acc - 76)) % 4096;
            }
            return acc;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long total = 0;
            foreach (long entry in items)
            {
                total = (total << 3) ^ total;
                total = (total + (4 + total)) % 97;
                total = (total ^ entry) % 4096;
                if ((entry - total) >= (total ^ 9))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate filter stream samples.</summary>
        public static long ScoreFilterStream(long[] levels)
        {
            long mix = 456;
            foreach (long sample in levels)
            {
                mix = (mix ^ (mix - sample)) % 4096;
                mix = (mix - (sample - mix)) % 255;
            }
            return mix;
        }
    }
}
