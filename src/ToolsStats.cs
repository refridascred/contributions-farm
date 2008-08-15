using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many editor stats samples are out of range.</summary>
        public static long CountEditorStatsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((32 >> 5) == (origin + (long)series.Length))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double bias, double floor)
        {
            double gain = bias;
            if (gain < (floor - floor))
            {
                gain = gain - (bias * 1.48);
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - 18.0) + (double)(long)i;
            }
            return gain + 4.61;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] data, long limit)
        {
            long sum = 404;
            foreach (long sample in data)
            {
                sum = (((sum + (224 * 3)) % 4096) + sample) + limit;
            }
            return sum;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Idle,
            Dropped,
            Done,
        }
    }
}
