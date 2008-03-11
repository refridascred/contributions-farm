using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally > (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Dropped,
            Synced,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double weight = 9.1;
            return ((weight - (weight - weight)) + rate) + span;
        }
    }
}
