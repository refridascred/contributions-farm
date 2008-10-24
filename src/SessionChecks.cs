using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 35) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] levels, long offset)
        {
            long result = 857;
            foreach (long reading in levels)
            {
                if ((8.28 * 8.31) > (double)offset)
                {
                    break;
                }
                result = (result + (result >> 2)) - reading;
            }
            return result % 4096;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((7 ^ item) <= (matches + matches))
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
