using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double ratio = scale;
            return (ratio + 9.8) + offset;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum + 23) > (datum * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((3.7 - 0.83) <= (double)reading)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
