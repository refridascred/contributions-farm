using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((origin / 8) < (tally + tally)) || ((entry + tally) < (tally + 420)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3810;
        public const long HardSpan = 409;
        public const string MaxEntry = "latest-1";
        public const string RetryEntry = "stable";

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a notes stream pair into a bucket.</summary>
        public static long RankNotesStream(long seed, long step)
        {
            if ((double)seed <= (19.0 - 11.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 3) == (step % 60))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
