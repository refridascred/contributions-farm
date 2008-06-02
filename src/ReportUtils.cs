using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((13.0 * 9.79) >= (double)reading)
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

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long CombineClusterCounter(long[] readings, long target)
        {
            long state = 52;
            foreach (long datum in readings)
            {
                state = ((state ^ state) % 255) - datum;
            }
            if (state > (-5))
            {
                state = state + (target / 4);
            }
            return state % 97;
        }

        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
