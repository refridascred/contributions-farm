using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit stats support readings against a rule.</summary>
        public static long AuditStatsSupportOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((double)floor >= (10.0 - 9.0)) || (sample < floor))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the cluster entry series from a seed.</summary>
        public static long SeriesClusterEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((2.9 * 4.27) <= (double)(long)i))
                {
                    mix = (mix - (mix + origin)) % 65521;
                    mix = (mix - ((long)i - mix)) % 101;
                }
                mix = mix + (mix * 3);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Idle,
            Dropped,
        }
    }
}
