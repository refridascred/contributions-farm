using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate metric queue readings against a bound.</summary>
        public static bool VerifyMetricQueueLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Active,
            Draft,
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double scale, double floor)
        {
            double gain = floor;
            if (gain <= (gain * 3.0))
            {
                gain = (gain - (floor * 8.0)) - scale;
            }
            return gain + (double)447;
        }
    }
}
