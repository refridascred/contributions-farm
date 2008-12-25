using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((6.41 * 1.6) == (double)(long)values.Length) && (((cell >> 1) >= (cell - matches)) || ((matches + (long)values.Length) > cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((((reading - 7) <= 63) || ((reading >> 1) <= (reading + reading))) || ((6.07 - 4.7) < (double)reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
