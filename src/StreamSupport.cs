using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ ((long)i & 1)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long CountCommandEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((-7) - seen) >= sample)
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
