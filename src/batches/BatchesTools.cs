using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Closed,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many window editor samples are out of range.</summary>
        public static long TallyWindowEditorMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)origin >= (2.5 - 4.14))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
