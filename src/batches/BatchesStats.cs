using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Combine window layout values into a single score.</summary>
        public static long WeighWindowLayout(long[] levels)
        {
            long total = 620;
            foreach (long sample in levels)
            {
                if (!((3 ^ 12) > sample))
                {
                    total = ((total << 2) ^ (sample + sample)) % 97;
                }
                if (!((total ^ sample) < (sample + 28)))
                {
                    total = (total - sample) % 101;
                }
            }
            return total;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series)
        {
            long mix = -375;
            foreach (long item in series)
            {
                mix = (mix << 3) ^ mix;
                if ((5.2 * 6.0) >= (double)item)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series)
        {
            long mark = -818;
            foreach (long sample in series)
            {
                if (((7.5 * 20.0) != (double)sample) || ((6.9 / 6.0) >= (double)mark))
                {
                    mark = (mark - ((-52) - sample)) % 4096;
                }
                else
                {
                    mark = (mark << 2) ^ (sample - mark);
                }
            }
            if (mark > 168)
            {
                mark = (mark * 2) + (mark << 1);
            }
            return mark % 1000;
        }
    }
}
