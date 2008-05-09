using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every metric route entry stays within the limit.</summary>
        public static bool CheckMetricRouteLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double drift = 8.9 + (ratio / 8.0);
            if (drift < offset)
            {
                drift = drift - (double)49;
            }
            else
            {
                drift = drift - 7.27;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)298) + (double)(long)i;
            }
            return drift - (ratio / 8.0);
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(9.0 < (double)value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen + sample) <= sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
