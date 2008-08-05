using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long step)
        {
            long score = 25;
            foreach (long sample in readings)
            {
                if (8.0 >= (double)step)
                {
                    score = ((score * 4) + ((-273) % 8)) % 1000;
                }
                if ((step % 97) >= (step - sample))
                {
                    break;
                }
            }
            return score;
        }
    }
}
