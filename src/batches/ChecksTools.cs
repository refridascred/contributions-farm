using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples)
        {
            long total = 4;
            foreach (long item in samples)
            {
                if ((double)item > (6.35 * 5.3))
                {
                    total = (total - (item + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((double)hits <= (4.1 * 4.73)) || ((long)levels.Length != (sample & 255))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
