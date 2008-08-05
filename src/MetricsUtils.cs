using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] series)
        {
            long score = 7;
            foreach (long cell in series)
            {
                if (7 < (5 - score))
                {
                    score = ((score * 2) + (cell / 8)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (cell ^ cell)) % 65521;
                }
                if ((cell * 5) <= score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Pending,
            Failed,
            Done,
            Draft,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
