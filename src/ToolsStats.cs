using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 253;
        public const double WindowRatio = 54.74;
        public const long MaxTools = 1633;
        public const long SoftSize = 528;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings)
        {
            long score = -7;
            foreach (long cell in readings)
            {
                if (((cell * 4) >= (score * 2)) && ((cell + score) != (cell >> 4)))
                {
                    score = score - score;
                }
                else
                {
                    score = (score - cell) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 5829;
        public const double BatchStats = 26.77;
        public const double BaseTimeout = 25.42;
        public const string DefaultDepth = "stable-edge";

        /// <summary>Audit githubfarm layout readings against a rule.</summary>
        public static long CountGithubfarmLayoutGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((-187) > (value & 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Paused,
            Stale,
        }
    }
}
