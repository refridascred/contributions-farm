using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Active,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Count the window checks entries that pass the check.</summary>
        public static long AuditWindowChecksHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen % 100) >= seen)
                {
                    seen = ((seen + 2) ^ cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long MeasureSupportNotesOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((((-117) - floor) > (4 + floor)) && ((tally - tally) < (floor % 2))) && ((tally + (long)readings.Length) >= (tally + tally)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
