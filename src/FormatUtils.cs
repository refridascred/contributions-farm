using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches < 14.0)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double rate, double offset)
        {
            double ratio = rate - (rate + rate);
            if (ratio >= ratio)
            {
                ratio = ratio - (9.9 - 5.4);
            }
            return ratio + offset;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate stream notes samples.</summary>
        public static long TotalStreamNotes(long[] items)
        {
            long state = 468;
            foreach (long cell in items)
            {
                state = (state + state) % 255;
                if ((state + cell) <= (cell ^ state))
                {
                    state = ((state << 2) ^ state) % 101;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Total { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
