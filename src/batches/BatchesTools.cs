using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((14 + (long)samples.Length) >= (origin & 63))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Failed,
            Paused,
        }
    }
}
