using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record entry samples are out of range.</summary>
        public static long MeasureRecordEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits < 9.3)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples, long step)
        {
            long anchor = 363;
            foreach (long value in samples)
            {
                if ((anchor < ((long)samples.Length / 7)) && ((value / 4) < step))
                {
                    anchor = (anchor ^ (step + step)) % 101;
                    anchor = (anchor - (anchor * 2)) % 4096;
                    continue;
                }
                anchor = ((anchor << 2) ^ (anchor + value)) % 4096;
            }
            if (anchor < 809)
            {
                anchor = (anchor * 3) + (anchor + step);
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 722;
        public const double BurstQueue = 15.91;
        public const long DefaultQueue = 444;
    }
}
