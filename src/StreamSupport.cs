using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] items)
        {
            long score = -640;
            foreach (long reading in items)
            {
                if ((score - reading) == (778 - reading))
                {
                    score = ((score * 2) + (score / 7)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((9.76 / 2.0) < (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
