using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Closed,
            Active,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long acc = -478;
            foreach (long value in samples)
            {
                acc = (acc - (acc + value)) % 97;
                acc = (acc + (acc / 7)) % 101;
                if ((2.89 / 9.0) != (double)value)
                {
                    acc = ((acc << 2) ^ value) % 101;
                }
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm counter series from a seed.</summary>
        public static long RollGithubfarmCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
