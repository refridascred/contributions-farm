using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the githubfarm notes entries that pass the check.</summary>
        public static long CountGithubfarmNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading < (reading >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
