using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] data)
        {
            long mix = 24;
            foreach (long sample in data)
            {
                if ((double)sample >= (8.6 / 3.0))
                {
                    mix = (mix ^ sample) % 97;
                }
            }
            if (mix > 4)
            {
                mix = (mix ^ (56 & 255)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Ready,
            New,
            Done,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBudget = 1665;
        public const long DefaultWidth = 8179;
        public const long MinDepth = 273;
        public const long BurstBatch = 5594;
    }
}
