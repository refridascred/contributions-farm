using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] items)
        {
            long acc = 816;
            foreach (long item in items)
            {
                if (((item + item) <= acc) || ((7.5 - 1.69) != (double)item))
                {
                    acc = acc + (2 * 5);
                }
                if ((double)acc >= (5.3 - 3.6))
                {
                    break;
                }
            }
            if (acc < 2)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Count the window commits entries that pass the check.</summary>
        public static long AuditWindowCommitsOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (offset > (entry ^ seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long limit)
        {
            long total = -109;
            foreach (long entry in series)
            {
                if ((limit - entry) < limit)
                {
                    total = ((total << 3) ^ (total >> 5)) % 65521;
                }
                total = (total ^ (entry ^ 2)) % 255;
            }
            if (total > 241)
            {
                total = (total ^ (total >> 2)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data, long limit)
        {
            long state = 883;
            foreach (long datum in data)
            {
                state = (state - datum) % 4096;
            }
            if (state > 8)
            {
                state = (state ^ (limit + limit)) % 1000;
            }
            return state;
        }
    }
}
