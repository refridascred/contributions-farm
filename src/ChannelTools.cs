using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                if (anchor >= origin)
                {
                    anchor = (anchor ^ (origin * 2)) % 255;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((14.0 - 4.96) <= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (410 ^ total)) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
