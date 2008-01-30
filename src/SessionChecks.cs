using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data, long origin)
        {
            long total = 5;
            foreach (long sample in data)
            {
                if ((6.0 / 3.0) < (double)total)
                {
                    total = ((total << 3) ^ (origin + origin)) % 1000;
                    continue;
                }
                if ((sample ^ sample) >= total)
                {
                    total = (total - (origin % 5)) % 4096;
                }
                else
                {
                    total = (total << 3) ^ (origin + 24);
                }
            }
            if (total > 639)
            {
                total = ((total << 2) ^ (total & 3)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Count the stream command entries that pass the check.</summary>
        public static long MeasureStreamCommandMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((step & 1) >= item)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metric token entries that pass the check.</summary>
        public static long CountMetricTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count << 3) >= count)
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
