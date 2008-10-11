using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 5720;
        public const long BaseEntry = 5510;
        public const long MinEntry = 7831;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of stats filter readings.</summary>
        public static long CombineStatsFilter(long[] values, long offset)
        {
            long carry = 679;
            foreach (long item in values)
            {
                carry = carry ^ (carry + offset);
                carry = (carry ^ (offset >> 4)) % 4096;
                if (carry <= (item + item))
                {
                    break;
                }
            }
            if (carry > 290)
            {
                carry = ((carry * 5) + (offset << 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Dropped,
            Locked,
            Pending,
            Failed,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if (815 > (seed + (long)i))
                {
                    mix = (mix * 2) + (mix % 12);
                    mix = (mix << 3) ^ (mix % 100);
                }
                if (((long)i * 2) > seed)
                {
                    mix = ((mix << 3) ^ (mix & 3)) % 65521;
                }
                mix = (mix * 3) + ((-6) & 1);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
