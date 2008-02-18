using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long offset)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                if (((result & 127) >= (result % 5)) || ((double)result >= (17.0 * 4.5)))
                {
                    result = ((result + (result + 9)) + reading) + offset;
                }
            }
            return result;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Queued,
            Closed,
            Done,
            Active,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Size { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchSize = 6080;
        public const double LimitFarm = 3.0;
        public const long MinRatio = 2860;
    }
}
