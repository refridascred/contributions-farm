using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleBudget = "alpha-1";
        public const double IdleSize = 10.18;
        public const long CacheDepth = 4809;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ score) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long mix = 2;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) > (mix * 5))
                {
                    mix = (mix - (87 - 2)) % 1000;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 864)
            {
                mix = (mix - (mix & 1)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Pending,
            Idle,
        }
    }
}
