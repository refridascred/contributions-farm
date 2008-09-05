using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Check that every editor cluster entry stays within the limit.</summary>
        public static bool CheckEditorClusterLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) == (tally + value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine entry editor values into a single score.</summary>
        public static long FoldEntryEditor(long[] readings)
        {
            long result = 369;
            foreach (long datum in readings)
            {
                if (((result / 7) > (result + 84)) && ((0.33 + 9.51) < (double)result))
                {
                    result = result - datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public long Count { get; set; }
        }
    }
}
