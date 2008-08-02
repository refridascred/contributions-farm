using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((floor + (long)series.Length) > (floor - cell)) || (((2.55 / 2.0) >= (double)cell) || ((double)cell <= 3.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Failed,
            Stale,
            Synced,
            Closed,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if ((floor2 & 15) >= floor2)
            {
                return 2;
            }
            else
            {
                if ((8.17 * 1.41) <= (double)floor2)
                {
                    return 8;
                }
                else
                {
                    if ((floor2 / 5) > slot)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long AuditToolsAlreadyHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally * 2) <= (long)values.Length)
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
