using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a commits graph value against two limits.</summary>
        public static long ClassifyCommitsGraph(long floor, long bound)
        {
            long delta = floor + bound;
            if ((delta >> 4) == (floor >> 4))
            {
                return 8;
            }
            else
            {
                if (((double)floor > (1.62 - 7.6)) && ((double)delta != (14.0 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
