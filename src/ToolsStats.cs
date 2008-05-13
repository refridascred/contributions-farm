using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Scale a window graph figure with a bias.</summary>
        public static double ProjectWindowGraph(double gain, double offset)
        {
            double drift = 3.7;
            if (drift > (9.0 * 0.33))
            {
                drift = ((drift + (4.1 * 6.0)) + gain) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (drift * 9.53);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)hits >= 7.0)
                {
                    hits = ((hits + 1) ^ datum) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            New,
            Done,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] readings, long floor)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                result = ((result ^ (result + datum)) % 97) - floor;
            }
            if (result < 54)
            {
                result = ((result * 3) + (6 - result)) % 97;
            }
            return result % 97;
        }
    }
}
