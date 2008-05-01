using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route profile entry stays within the limit.</summary>
        public static bool ValidateRouteProfileRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((11.0 * 18.0) <= (double)matches)
                {
                    matches = ((matches + 3) + cell) + bound;
                }
            }
            return matches;
        }
    }
}
