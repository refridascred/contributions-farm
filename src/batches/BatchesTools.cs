using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels, long floor)
        {
            long mark = -594;
            foreach (long sample in levels)
            {
                if ((sample << 2) <= mark)
                {
                    continue;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark / 7)) % 255;
                }
                if ((sample + mark) > (sample + floor))
                {
                    mark = ((mark * 5) + (floor >> 3)) % 101;
                }
            }
            if (mark < 11)
            {
                mark = mark - (floor >> 3);
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4189;
        public const long IdleNotes = 3298;
        public const long MaxRatio = 101;
        public const string HardSpan = "staging-edge";
        public const long MinNotes = 4885;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = (mix ^ sample) % 255;
            }
            return mix % 4096;
        }
    }
}
