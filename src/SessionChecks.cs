using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the batch record entries that pass the check.</summary>
        public static long MeasureBatchRecordHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + limit) < 20)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long carry = 47;
            foreach (long reading in samples)
            {
                if ((9.3 * 1.9) < (double)carry)
                {
                    break;
                }
                if ((2.0 + 12.0) == (double)carry)
                {
                    carry = (carry - (reading * 4)) % 65521;
                }
                carry = (carry * 5) + (reading + reading);
            }
            return carry % 1000;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Retry,
            Paused,
        }
    }
}
