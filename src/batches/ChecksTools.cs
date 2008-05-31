using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks route entry that matches the target.</summary>
        public static long FindChecksRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches record samples are out of range.</summary>
        public static long AuditBatchesRecordOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((3.0 * 12.0) >= (double)datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((floor + total) > (floor >> 5)))
                {
                    total = total + (floor + floor);
                }
                total = (total * 3) + floor;
                total = (total ^ (total + floor)) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
