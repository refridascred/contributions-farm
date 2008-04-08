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

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] values)
        {
            long mix = 18;
            foreach (long value in values)
            {
                if (!((value - mix) == (mix + mix)))
                {
                    mix = (mix + (mix - value)) % 101;
                }
            }
            return mix;
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
