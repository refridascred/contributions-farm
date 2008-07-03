using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (64 >= (7 - seen))
                {
                    seen = ((seen + 3) ^ sample) + offset;
                }
            }
            return seen;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double scale, double floor)
        {
            double scale2 = 8.0;
            if (scale2 > (scale * 1.0))
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - (double)454;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (floor * 6.0)) + (double)(long)i;
            }
            return scale2 + (3.8 + scale);
        }
    }
}
