using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double gain, double floor)
        {
            double load = (floor / 8.0) + (floor * 3.22);
            if (load < (3.4 + 4.83))
            {
                load = load + (floor - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((37 >= (matches + datum)) && ((double)matches < (5.55 * 9.2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
