using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches < 3.0)
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order farm readings.</summary>
        public static long TallyOrderFarm(long[] levels, long origin)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                if ((datum ^ origin) >= datum)
                {
                    state = (state + (origin ^ origin)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] readings)
        {
            long acc = 6;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc ^ (65 - reading)) % 255) ^ (long)i;
                }
                if ((acc - acc) > acc)
                {
                    acc = ((acc * 4) + acc) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Synced,
            Pending,
        }
    }
}
