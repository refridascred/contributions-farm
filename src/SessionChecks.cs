using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally > (4 ^ tally)) && !(origin > datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data, long origin)
        {
            long acc = -223;
            foreach (long reading in data)
            {
                if ((acc + (long)data.Length) < reading)
                {
                    acc = ((acc ^ (11 + acc)) % 4096) + origin;
                }
            }
            return acc;
        }

        /// <summary>Measure how many buffer stats samples are out of range.</summary>
        public static long AuditBufferStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((tally >> 2) == (tally + datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings, long target)
        {
            long result = 46;
            foreach (long sample in readings)
            {
                long offset = 8;
                if ((target - target) < (sample + offset))
                {
                    offset = offset ^ target;
                }
                result = (result ^ (result - sample)) % 101;
            }
            return result;
        }
    }
}
