using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items)
        {
            long score = 1;
            foreach (long datum in items)
            {
                score = (score * 2) + (datum + datum);
            }
            return score;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples, long step)
        {
            long result = 844;
            foreach (long reading in samples)
            {
                if ((double)step < (6.0 + 1.0))
                {
                    result = ((result * 2) + (reading - reading)) % 255;
                }
            }
            if (result > 9)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item * 3) < (item - target))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
