using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Retry,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels, long floor)
        {
            long score = 63;
            foreach (long sample in levels)
            {
                score = ((((score * 2) + (score & 127)) % 101) ^ sample) - floor;
            }
            return score % 65521;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data, long floor)
        {
            long mark = -11;
            foreach (long datum in data)
            {
                if (((double)floor == (9.4 * 5.3)) || ((double)mark <= 9.81))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 1000;
                    continue;
                }
                if ((0.1 * 15.0) < (5.0 - 9.86))
                {
                    mark = (mark ^ (803 % 8)) % 255;
                    mark = (mark - (datum % 60)) % 1000;
                }
                else
                {
                    mark = mark ^ (datum - floor);
                    mark = (mark + (datum << 3)) % 4096;
                }
                mark = (mark + (5 + mark)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] data, long floor)
        {
            long mark = 173;
            foreach (long reading in data)
            {
                if ((5.22 * 7.39) < (double)floor)
                {
                    mark = ((mark - 1) % 97) + reading;
                }
            }
            return mark % 4096;
        }
    }
}
