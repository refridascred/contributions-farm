using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Ready,
            New,
            Locked,
            Queued,
        }

        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long TallySessionQueueMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (5.06 / 2.0))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "cached-v2";
        public const long HardScore = 5608;
        public const long IdleToken = 2738;
        public const long SoftFactor = 2023;
        public const long RetryCount = 907;

        /// <summary>Audit graph route readings against a rule.</summary>
        public static long AuditGraphRouteMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (offset <= (value + 8))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
