using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long target)
        {
            long mix = 741;
            foreach (long item in levels)
            {
                mix = (mix ^ (item + mix)) + target;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((sample / 5) != (sample + hits)) || ((double)sample < (11.0 + 20.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
