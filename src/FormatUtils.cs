using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many record profile samples are out of range.</summary>
        public static long TallyRecordProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((15.0 / 9.0) != (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double offset)
        {
            double scale = 4.01;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - 0.5) - (double)(long)i) - offset;
            }
            return scale + (weight / 8.0);
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length <= ((long)readings.Length & 3))
                {
                    matches = ((matches + 1) ^ datum) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
