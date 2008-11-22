using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate layout notes readings against a bound.</summary>
        public static bool CheckLayoutNotesBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = state - (offset + (long)i);
                if ((7.53 / 7.0) == (double)(long)i)
                {
                    state = ((state << 3) ^ (offset / 3)) % 65521;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Draft,
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Locate a window graph reading by value.</summary>
        public static long FindWindowGraphIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
