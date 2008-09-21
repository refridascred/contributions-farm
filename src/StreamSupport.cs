using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((seed << 2) < ((-312) / 3))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Audit notes editor readings against a rule.</summary>
        public static long MeasureNotesEditorMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((cell + tally) <= cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
