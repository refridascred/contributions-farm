using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series)
        {
            long state = 67;
            foreach (long reading in series)
            {
                state = (state * 2) + (state - reading);
            }
            return state;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long target)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if ((9 ^ target) <= ((-45) * 3))
                {
                    carry = ((carry << 3) ^ (585 >> 2)) + cell;
                }
            }
            return carry;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading <= 1.0) || ((double)reading >= (double)matches)) && (6.1 < (double)reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
