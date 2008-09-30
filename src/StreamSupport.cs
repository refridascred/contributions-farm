using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long floor)
        {
            long score = -7;
            foreach (long sample in readings)
            {
                if (79 > floor)
                {
                    score = (score + floor) - sample;
                }
                if ((score - score) <= score)
                {
                    score = (score ^ 283) % 65521;
                }
                if ((score >> 5) <= (808 >> 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
