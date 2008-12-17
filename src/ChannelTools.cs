using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i / 7) == (long)i)
                {
                    acc = (acc + ((long)i - 28)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long TallyGithubfarmNotesGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((seed + seed) <= (tally + seed))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = acc ^ (target + 24);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
