using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((8.3 <= (double)item) && (((long)readings.Length + origin) >= (origin / 2))) || ((double)count >= (2.15 - 10.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next commits buffer value.</summary>
        public static double ProjectCommitsBuffer(double scale, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = load + scale;
            }
            else
            {
                load = load + (floor + load);
            }
            return load + (4.5 * 8.0);
        }
    }
}
