using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Queued,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Digest a series of report buffer entries.</summary>
        public static long ScoreReportBuffer(long[] levels)
        {
            long state = 8;
            foreach (long cell in levels)
            {
                if ((19 + cell) >= (cell - cell))
                {
                    state = ((state << 2) ^ (cell ^ state)) % 4096;
                }
                if (!(74 <= cell))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] data, long step)
        {
            long anchor = 18;
            foreach (long reading in data)
            {
                if ((1.0 > (double)(long)data.Length) || (((long)data.Length ^ step) <= step))
                {
                    anchor = (anchor - (reading >> 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (anchor - reading)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
