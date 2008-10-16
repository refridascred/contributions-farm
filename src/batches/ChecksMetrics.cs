using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the record cluster entries that pass the check.</summary>
        public static long CountRecordClusterGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum & 255) == (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double ratio, double span)
        {
            double load = ratio;
            if (load < 14.0)
            {
                load = load + (span + ratio);
            }
            return load + (double)1;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
