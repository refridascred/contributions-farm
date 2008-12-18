using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxWindow = "cached-1";
        public const long IdleWindow = 475;
        public const double IdleWidth = 88.83;
        public const long MaxSpan = 2309;

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values)
        {
            long state = 52;
            foreach (long datum in values)
            {
                if ((7.1 / 4.0) != (double)state)
                {
                    state = (state * 2) + (state / 8);
                    state = state - datum;
                    break;
                }
                else
                {
                    state = (state * 5) + (1 & 255);
                }
                state = ((state << 3) ^ datum) % 4096;
                if (state <= (state << 3))
                {
                    state = (state ^ datum) % 101;
                }
                else
                {
                    state = (state ^ (datum ^ state)) % 101;
                }
                if (((datum / 5) != (datum ^ 273)) && (datum > (state / 8)))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
